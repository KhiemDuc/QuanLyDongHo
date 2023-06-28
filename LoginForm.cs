
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using TodoApp.MyClass;
using DAL;
using System.Data;

namespace TodoApp
{
    public partial class LoginForm : Form
    {
        private LoginDAL Login = new LoginDAL();
        public LoginForm()
        {
            InitializeComponent();
        }
        // Login and Register
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblValidateLogin.Text = String.Empty;

            Task<DataTable> task = Login.LoginAndGetRole(txtUsername.Text, txtPassword.Text);

            task.ContinueWith(LoginContinue =>
            {

                if (LoginContinue.IsFaulted)
                {
                    LoginFault();
                }
                else
                {
                    try
                    {
                        DataRow firstRow = LoginContinue.Result.Rows[0]; // Lấy dòng đầu tiên

                        string id = ((int)firstRow["MaThanhVien"]).ToString();
                        string role = (string)firstRow["Ma_ChucVu"];
                        string name = (string)firstRow["Ten"];

                        if (InvokeRequired)
                        {
                            Invoke(new Action(() =>
                            {
                                Form f = new Home(role.Trim(),id.Trim(),name.Trim());
                                f.Show(this);
                                Hide();
                            }));
                        }
                    }
                    catch
                    {
                        LoginFail();
                    }
                }
            });
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        void LoginFail()
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lblValidateLogin.Text = "Tài khoản hoặc mật khẩu không đúng";
                }));
            }
            else
            {
                lblValidateLogin.Text = "Tài khoản hoặc mật khẩu không đúng";
            }
        }

        void LoginFault()
        {
            if (this.InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    lblValidateLogin.Text = "Đăng nhập không thành công";
                }));
            }
            else
            {
                lblValidateLogin.Text = "Đăng nhập không thành công";
            }
        }
        private void Validation(object sender, EventArgs e)
        {
            validate();
        }

        void validate()
        {
            var _bIsEmptyUserName = string.IsNullOrWhiteSpace(txtUsername.Text);
            var _bIsEmptyPassword = string.IsNullOrWhiteSpace(txtPassword.Text);

            lblValidateUserName.Visible = _bIsEmptyUserName;
            lblValidatePass.Visible = _bIsEmptyPassword;

            btnLogin.Enabled = !_bIsEmptyUserName && !_bIsEmptyPassword;

            lblValidateLogin.Text = String.Empty;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MyValidateAllControl.SetTextBoxEventTextChanged(Controls, Validation);
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblChangePass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var doimatkhau = new DoiMatKhau();
            doimatkhau.ShowDialog();
        }

        private void hideAndShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            hideAndShowPass.Image = txtPassword.UseSystemPasswordChar ?
                Properties.Resources.icons8_hide_24 : Properties.Resources.icons8_eye_24;
        }
    }
}
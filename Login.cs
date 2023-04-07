using DAL;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace TodoApp
{
    public partial class Login : Form
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        private UserAccess userAccess = new UserAccess();
        private bool IsCancel;
        public Login()
        {
            InitializeComponent();
            SetTextBoxEvent(Controls);
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblUnderUser.ForeColor = Color.Turquoise;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            lblUnderUser.ForeColor = Color.Black;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            lblUnderPassword.ForeColor = Color.Turquoise;
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            lblUnderPassword.ForeColor = Color.Black;
        }


        // Validate Text Box
        private void SetTextBoxEvent(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                    control.TextChanged += new EventHandler(Validation);
                }
                else if (control.Controls.Count > 0)
                {
                    SetTextBoxEvent(control.Controls);
                }
            }

        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Validation(object sender, EventArgs e)
        {
            validate();
            (sender as TextBox).Text = Regex.Replace((sender as TextBox).Text, @"\s+", "");
        }
        private void validate()
        {
            var _bIsEmptyUserName = string.IsNullOrWhiteSpace(txtUsername.Text);
            var _bIsEmptyPassword = string.IsNullOrWhiteSpace(txtPassword.Text);

            btnLogin.Enabled = !_bIsEmptyUserName && !_bIsEmptyPassword;

            if (_bIsEmptyUserName)
            {
                lblValidateUserName.Text = " Không được để trống tài khoản";
            }
            else
                lblValidateUserName.Text = String.Empty;

            if (_bIsEmptyPassword)
            {
                lblValidatePass.Text = " Không được để trống mật khẩu";
            }
            else
                lblValidatePass.Text = String.Empty;

            lblValidateLogin.Text = String.Empty;
        }

        // Login and Register
        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblValidateLogin.Text = String.Empty;

            if(IsCancel)
            {
                cts.Cancel();
            }

            IsCancel = !IsCancel;
            btnLogin.Text = IsCancel ? "Hủy" : " Đăng nhập";
            
            Task <string> task = userAccess.LoginAndGetUserID(txtUsername.Text, txtPassword.Text, cts.Token);

            task.ContinueWith(t =>
            {

                if (t.Status == TaskStatus.Canceled)
                {
                    LoginFault();
                    cts = new CancellationTokenSource();
                }

                else if(t.Status == TaskStatus.Faulted)
                {
                    LoginFault();
                    cts = new CancellationTokenSource();
                }
                else
                {
                    try
                    {
                        if (t.Result != null)
                        {
                            BeginInvoke(new Action(() =>
                            {
                                Form f = new TodoList(txtUsername.Text, t.Result);
                                f.Show(this);
                                Hide();
                            }));
                        }
                        else
                        {
                            LoginFail();
                        }
                    }
                    catch
                    {
                        LoginFail();
                    }
                    finally
                    {
                        IsCancel = false;
                        BeginInvoke(new Action(() =>
                        {
                            btnLogin.Text = "Đăng nhập";
                        }));
                    }
                }
            });  
        }
        private void LoginFail()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    lblValidateLogin.Text = "Tài khoản hoặc mật khẩu không đúng";
                }));
            }
            else
            {
                lblValidateLogin.Text = "Tài khoản hoặc mật khẩu không đúng";
            }
        }
        private void LoginFault()
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action(() =>
                {
                    lblValidateLogin.Text = "Đăng nhập không thành công";
                }));
            }
            else
            {
                lblValidateLogin.Text = "Đăng nhập không thành công";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var f = new Register();
            f.Show(this);
            Hide();
        }

        private void hideAndShowPass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            hideAndShowPass.Image = txtPassword.UseSystemPasswordChar ?
                Properties.Resources.icons8_hide_24 :
                Properties.Resources.icons8_eye_24;
        }
    }
}

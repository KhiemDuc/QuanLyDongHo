
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{

    public partial class Register : Form
    {
        private CancellationTokenSource cts = new CancellationTokenSource();
        private UserAccess userAccess = new UserAccess();
        private bool isCancel;

        public Register()
        {
            InitializeComponent();
            SetTextBoxEvent(this.Controls);
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisposeGarbage();

            if (Owner != null && !Owner.Disposing &&
                    !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();
        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Owner != null && !Owner.Disposing &&
                    !Owner.IsDisposed && !Owner.Visible)
                Owner.Show();

            Close();
        }

        private void DisposeGarbage()
        {
            cts.Dispose();
            userAccess.Dispose();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblValidateResgister.Text = string.Empty;

            if (isCancel)
            {
                cts.Cancel();
            }

            isCancel = !isCancel;
            btnRegister.Text = isCancel ? "Huỷ" : "Đăng ký";

            Task<bool> _tcheckUser = userAccess.CheckUser(txtUserName.Text.ToLower(), cts.Token);
            _tcheckUser.ContinueWith(t =>
            {
                try
                {
                    if (t.Result == true)
                    {
                        this.BeginInvoke(new Action(() =>
                        {
                            lblValidateResgister.Text = "Tài khoản đã tồn tại";
                            lblValidateResgister.ForeColor = Color.Red;
                        }));
                    }
                    else if (t.Status == TaskStatus.Faulted)
                    {
                        RegisterFault();
                        cts = new CancellationTokenSource();
                    }
                    else
                    {
                        RegisterUser();
                    }
                }
                catch
                {
                    RegisterFault();
                }
                finally
                {
                    _tcheckUser.Dispose();
                    isCancel = false;
                    BeginInvoke(new Action(() =>
                    {
                        btnRegister.Text = "Đăng ký";

                    }));
                }
            });

        }
        private void RegisterUser()
        {
            Task register = userAccess.InsertUserDAL(txtUserName.Text, txtPassword.Text, txtEmail.Text, cts.Token);

            register.ContinueWith(r =>
            {
                if (r.Status == TaskStatus.Faulted)
                {
                    RegisterFault();
                    cts = new CancellationTokenSource();
                }
                else
                {
                    RegisterDone();
                }

                register.Dispose();
            });
        }
        private void RegisterDone()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() =>
                {
                    lblValidateResgister.ForeColor = Color.Turquoise;
                    lblValidateResgister.Text = "Tạo thành công, bạn có thể đăng nhập";
                }));
            }
            else
            {
                lblValidateResgister.ForeColor = Color.Turquoise;
                lblValidateResgister.Text = "Tạo thành công, bạn có thể đăng nhập";
            }

        }
        private void RegisterFault()
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() =>
                {
                    lblValidateResgister.Text = "Tạo không thành công";
                    lblValidateResgister.ForeColor = Color.Red;
                }));
            }
            else
            {
                lblValidateResgister.Text = "Tạo không thành công";
                lblValidateResgister.ForeColor = Color.Red;
            }
        }

        private void ValidateTexBox()
        {
            lblValidateResgister.Text = "";

            var _tValidateUser = string.IsNullOrWhiteSpace(txtUserName.Text) || txtUserName.Text.Length < 5 ;
            var _tValidateEmail = string.IsNullOrWhiteSpace(txtEmail.Text);
            var _tValidatePass = string.IsNullOrWhiteSpace(txtPassword.Text);
            var _tValidateConfirm = string.IsNullOrWhiteSpace(txtConfirm.Text);

            var _iIsValidEmail = IsValidEmail(txtEmail.Text);
            var _iCheckConfirm = txtPassword.Text == txtConfirm.Text && txtPassword.Text != "" && txtConfirm.Text != "";

            btnRegister.Enabled = !_tValidateUser && !_tValidatePass && !_tValidateEmail && !_tValidateConfirm && _iCheckConfirm && _iIsValidEmail;

            lblValidateUsername.Text = _tValidateUser ? "Tài khoản không được để trống hoặc nhỏ hơn 5 ký tự" : string.Empty;
            lblvalidatePass.Text = _tValidatePass ? "Mật khẩu không được để trống " : string.Empty;

            if (_tValidateEmail)
            {
                lblValidateEmail.Text = "Email không được để trống";
            }
            else
            {
                lblValidateEmail.Text = _iIsValidEmail ? string.Empty : "Email không hợp lệ";

            }

            if (_tValidateConfirm)
            {
                lblValidateConfirm.Text = "Không được để trống mật khẩu";
            }
            else
            {
                lblValidateConfirm.Text = _iCheckConfirm ? string.Empty : "Mật khẩu xác nhận không trùng khớp";
            }

        }

        public bool IsValidEmail(string email)
        {
            if (email.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void pHidePass_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            pHidePass.Image = txtPassword.UseSystemPasswordChar ?
                Properties.Resources.icons8_hide_24 :
                Properties.Resources.icons8_eye_24;

            txtConfirm.UseSystemPasswordChar = txtPassword.UseSystemPasswordChar;

        }

        private void SetTextBoxEvent(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    control.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                    control.TextChanged += new EventHandler(Validation);
                    control.Enter += new EventHandler(Validation);
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
            ValidateTexBox();
            (sender as TextBox).Text = Regex.Replace((sender as TextBox).Text, @"\s+", "");
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.MyClass;
using DAL;

namespace TodoApp
{
    public partial class DoiMatKhau : Form
    {
        TaiKhoanDAL tk = new TaiKhoanDAL();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void hideAndShowOldPass_Click(object sender, EventArgs e)
        {
            txtOldPass.UseSystemPasswordChar = !txtOldPass.UseSystemPasswordChar;
            hideAndShowOldPass.Image = txtOldPass.UseSystemPasswordChar ?
                Properties.Resources.icons8_hide_24 : Properties.Resources.icons8_eye_24;
        }

        private void hideAndShowNewPass_Click(object sender, EventArgs e)
        {
            txtNewPass.UseSystemPasswordChar = !txtNewPass.UseSystemPasswordChar;
            txtPassConfirm.UseSystemPasswordChar = !txtPassConfirm.UseSystemPasswordChar;
            hideAndShowNewPass.Image = txtNewPass.UseSystemPasswordChar ?
                Properties.Resources.icons8_hide_24 : Properties.Resources.icons8_eye_24;
        }
        void validate()
        {
            var _vCheckUserName = string.IsNullOrWhiteSpace(txtUserName.Text);
            var _vCheckOldPass = string.IsNullOrWhiteSpace(txtOldPass.Text);
            var _vcheckNewPass = string.IsNullOrWhiteSpace(txtNewPass.Text);
            var _vcheckConfirmPass = string.IsNullOrWhiteSpace(txtNewPass.Text);
            var _vcheckChangePass = txtOldPass.Text == txtNewPass.Text;

            btnChangePass.Enabled = !_vcheckNewPass && !_vCheckOldPass && !_vCheckOldPass
                && !_vcheckConfirmPass && txtNewPass.Text == txtPassConfirm.Text && !_vcheckChangePass;

            lblValidateUser.Visible = _vCheckUserName;
            lblValiidateOldPass.Visible = _vCheckOldPass;
            lblValidateNewPass.Visible = _vcheckNewPass;

            lblValidateConfirmPass.Text = _vcheckConfirmPass ? "Không được để trống mật khẩu xác nhận" :
                txtNewPass.Text != txtPassConfirm.Text ? "Mật khẩu không trùng khớp" :
                _vcheckChangePass ? "Mật khẩu cũ và mới không khác nhau" : string.Empty;


        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            MyValidateAllControl.SetTextBoxEventTextChanged(Controls, Validation);

        }

        private void Validation(object sender, EventArgs e)
        {
            validate();
        }

        private async void btnChangePass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đổi mật khẩu không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await tk.UpdatePasswordUserAsync(txtUserName.Text,txtOldPass.Text,txtNewPass.Text);
                MessageBox.Show("Thay Đổi Mật Khẩu Thành Công");
                Close();
            }
            else if (result == DialogResult.No)
            {
                // Người dùng chọn No
                return;
            }
        }
    }
}

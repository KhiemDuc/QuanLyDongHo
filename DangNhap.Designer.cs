using System.Windows.Forms;

namespace TodoApp
{
    partial class DangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.TlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.lblValidateLogin = new System.Windows.Forms.Label();
            this.btnLogin = new TodoApp.Controls.CustomButton();
            this.panelForm = new System.Windows.Forms.Panel();
            this.txtPassword = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtUsername = new TodoApp.customControls.CustomTextBox(this.components);
            this.lblValidateUserName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChangePass = new System.Windows.Forms.LinkLabel();
            this.hideAndShowPass = new System.Windows.Forms.PictureBox();
            this.lblValidatePass = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblheader = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.TlpAction.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideAndShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1382, 669);
            this.panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TlpAction, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1382, 669);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::TodoApp.Properties.Resources.AnhDongHo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(736, 665);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // TlpAction
            // 
            this.TlpAction.ColumnCount = 1;
            this.TlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TlpAction.Controls.Add(this.panelLogin, 0, 2);
            this.TlpAction.Controls.Add(this.panelForm, 0, 1);
            this.TlpAction.Controls.Add(this.lblheader, 0, 0);
            this.TlpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TlpAction.Location = new System.Drawing.Point(745, 2);
            this.TlpAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TlpAction.Name = "TlpAction";
            this.TlpAction.RowCount = 4;
            this.TlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.02148F));
            this.TlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.37594F));
            this.TlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.11278F));
            this.TlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.203007F));
            this.TlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TlpAction.Size = new System.Drawing.Size(634, 665);
            this.TlpAction.TabIndex = 15;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.lblValidateLogin);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(3, 491);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(628, 161);
            this.panelLogin.TabIndex = 22;
            this.panelLogin.TabStop = true;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // lblValidateLogin
            // 
            this.lblValidateLogin.AutoSize = true;
            this.lblValidateLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblValidateLogin.ForeColor = System.Drawing.Color.Red;
            this.lblValidateLogin.Location = new System.Drawing.Point(119, 11);
            this.lblValidateLogin.Name = "lblValidateLogin";
            this.lblValidateLogin.Size = new System.Drawing.Size(0, 20);
            this.lblValidateLogin.TabIndex = 23;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogin.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(123, 56);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(422, 48);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.txtPassword);
            this.panelForm.Controls.Add(this.txtUsername);
            this.panelForm.Controls.Add(this.lblValidateUserName);
            this.panelForm.Controls.Add(this.pictureBox2);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.lblChangePass);
            this.panelForm.Controls.Add(this.hideAndShowPass);
            this.panelForm.Controls.Add(this.lblValidatePass);
            this.panelForm.Controls.Add(this.pictureBox3);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 155);
            this.panelForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(628, 331);
            this.panelForm.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.IsNotSpace = true;
            this.txtPassword.Location = new System.Drawing.Point(151, 204);
            this.txtPassword.MaxLength = 16;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.Size = new System.Drawing.Size(392, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UnderlinedStyle = true;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtUsername.BorderSize = 2;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.IsNotSpace = true;
            this.txtUsername.Location = new System.Drawing.Point(151, 96);
            this.txtUsername.MaxLength = 18;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(7);
            this.txtUsername.Size = new System.Drawing.Size(392, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UnderlinedStyle = true;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // lblValidateUserName
            // 
            this.lblValidateUserName.AutoSize = true;
            this.lblValidateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblValidateUserName.ForeColor = System.Drawing.Color.Red;
            this.lblValidateUserName.Location = new System.Drawing.Point(157, 132);
            this.lblValidateUserName.Name = "lblValidateUserName";
            this.lblValidateUserName.Size = new System.Drawing.Size(210, 18);
            this.lblValidateUserName.TabIndex = 27;
            this.lblValidateUserName.Text = "Không được để trống tài khoản";
            this.lblValidateUserName.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::TodoApp.Properties.Resources.icons8_user_481;
            this.pictureBox2.Location = new System.Drawing.Point(87, 98);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(33, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(81, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblChangePass
            // 
            this.lblChangePass.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChangePass.LinkColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblChangePass.Location = new System.Drawing.Point(437, 259);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(116, 20);
            this.lblChangePass.TabIndex = 4;
            this.lblChangePass.TabStop = true;
            this.lblChangePass.Text = "Đổi mật khẩu?";
            this.lblChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangePass_LinkClicked);
            // 
            // hideAndShowPass
            // 
            this.hideAndShowPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hideAndShowPass.Image = global::TodoApp.Properties.Resources.icons8_hide_24;
            this.hideAndShowPass.Location = new System.Drawing.Point(563, 204);
            this.hideAndShowPass.Name = "hideAndShowPass";
            this.hideAndShowPass.Padding = new System.Windows.Forms.Padding(2);
            this.hideAndShowPass.Size = new System.Drawing.Size(25, 25);
            this.hideAndShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hideAndShowPass.TabIndex = 22;
            this.hideAndShowPass.TabStop = false;
            this.hideAndShowPass.Click += new System.EventHandler(this.hideAndShowPass_Click);
            // 
            // lblValidatePass
            // 
            this.lblValidatePass.AutoSize = true;
            this.lblValidatePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblValidatePass.ForeColor = System.Drawing.Color.Red;
            this.lblValidatePass.Location = new System.Drawing.Point(157, 246);
            this.lblValidatePass.Name = "lblValidatePass";
            this.lblValidatePass.Size = new System.Drawing.Size(211, 18);
            this.lblValidatePass.TabIndex = 19;
            this.lblValidatePass.Text = "Không được để trống mật khẩu";
            this.lblValidatePass.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::TodoApp.Properties.Resources.icons8_password_30;
            this.pictureBox3.Location = new System.Drawing.Point(87, 204);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(33, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(81, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblheader
            // 
            this.lblheader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblheader.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblheader.Location = new System.Drawing.Point(3, 0);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(628, 153);
            this.lblheader.TabIndex = 18;
            this.lblheader.Text = "Đăng Nhập";
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1382, 669);
            this.Controls.Add(this.panel3);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1400, 700);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.TlpAction.ResumeLayout(false);
            this.TlpAction.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideAndShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private TableLayoutPanel TlpAction;
        private Panel panelLogin;
        private Label lblValidateLogin;
        private Controls.CustomButton btnLogin;
        private Panel panelForm;
        private customControls.CustomTextBox txtPassword;
        private customControls.CustomTextBox txtUsername;
        private Label lblValidateUserName;
        private PictureBox pictureBox2;
        private Label label2;
        private LinkLabel lblChangePass;
        private PictureBox hideAndShowPass;
        private Label lblValidatePass;
        private PictureBox pictureBox3;
        private Label label4;
        private Label lblheader;
    }
}

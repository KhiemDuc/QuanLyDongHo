namespace TodoApp
{
    partial class ThongTinCaNhan
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelRes = new System.Windows.Forms.Panel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.txtGioiTinh = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtHonNhan = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtVoChong = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtNgheNghiep = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtHocVan = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtHoTenMe = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtHoTenBo = new TodoApp.customControls.CustomTextBox(this.components);
            this.txtHoTen = new TodoApp.customControls.CustomTextBox(this.components);
            this.panelHonNhan = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelHonNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panelRes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelForm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44867F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.25602F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.29531F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(758, 789);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panelRes
            // 
            this.panelRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRes.Location = new System.Drawing.Point(3, 766);
            this.panelRes.Name = "panelRes";
            this.panelRes.Size = new System.Drawing.Size(752, 20);
            this.panelRes.TabIndex = 12;
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.label8);
            this.panelForm.Controls.Add(this.panelHonNhan);
            this.panelForm.Controls.Add(this.txtHonNhan);
            this.panelForm.Controls.Add(this.txtGioiTinh);
            this.panelForm.Controls.Add(this.txtNgheNghiep);
            this.panelForm.Controls.Add(this.label2);
            this.panelForm.Controls.Add(this.label5);
            this.panelForm.Controls.Add(this.txtHocVan);
            this.panelForm.Controls.Add(this.label6);
            this.panelForm.Controls.Add(this.label7);
            this.panelForm.Controls.Add(this.txtHoTenMe);
            this.panelForm.Controls.Add(this.label3);
            this.panelForm.Controls.Add(this.label4);
            this.panelForm.Controls.Add(this.txtHoTenBo);
            this.panelForm.Controls.Add(this.txtHoTen);
            this.panelForm.Controls.Add(this.dtpDateofBirth);
            this.panelForm.Controls.Add(this.lblConfirm);
            this.panelForm.Controls.Add(this.lblPass);
            this.panelForm.Controls.Add(this.lblUser);
            this.panelForm.Controls.Add(this.lblEmail);
            this.panelForm.Controls.Add(this.label1);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(3, 117);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(752, 643);
            this.panelForm.TabIndex = 21;
            this.panelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelForm_Paint);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(62, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(39, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 29);
            this.label10.TabIndex = 56;
            this.label10.Text = "Họ Tên Vợ/ Chồng";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(166, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 29);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tình Trạng Hôn Nhân";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(172, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(171, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nghề Nghiệp";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(171, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 29);
            this.label6.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(170, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 29);
            this.label7.TabIndex = 43;
            this.label7.Text = "Học Vấn";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(167, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(166, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 39;
            this.label4.Text = "Họ Tên Mẹ";
            // 
            // dtpDateofBirth
            // 
            this.dtpDateofBirth.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateofBirth.Location = new System.Drawing.Point(314, 89);
            this.dtpDateofBirth.Name = "dtpDateofBirth";
            this.dtpDateofBirth.Size = new System.Drawing.Size(258, 30);
            this.dtpDateofBirth.TabIndex = 29;
            // 
            // lblConfirm
            // 
            this.lblConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblConfirm.Location = new System.Drawing.Point(167, 229);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(0, 29);
            this.lblConfirm.TabIndex = 26;
            // 
            // lblPass
            // 
            this.lblPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPass.Location = new System.Drawing.Point(167, 155);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 29);
            this.lblPass.TabIndex = 10;
            this.lblPass.Text = "Giới Tính";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUser.Location = new System.Drawing.Point(166, 25);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(91, 29);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Họ Và Tên";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEmail.Location = new System.Drawing.Point(167, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 29);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(166, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Họ Tên Bố";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 108);
            this.panel1.TabIndex = 22;
            // 
            // labelHeader
            // 
            this.labelHeader.BackColor = System.Drawing.Color.White;
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHeader.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHeader.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(752, 108);
            this.labelHeader.TabIndex = 19;
            this.labelHeader.Text = "Thông Tin Cá Nhân";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelHeader.Click += new System.EventHandler(this.labelHeader_Click);
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.Color.White;
            this.txtGioiTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGioiTinh.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtGioiTinh.BorderSize = 1;
            this.txtGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGioiTinh.IsNotSpace = false;
            this.txtGioiTinh.Location = new System.Drawing.Point(314, 148);
            this.txtGioiTinh.MaxLength = 30;
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Padding = new System.Windows.Forms.Padding(7);
            this.txtGioiTinh.Size = new System.Drawing.Size(166, 36);
            this.txtGioiTinh.TabIndex = 59;
            this.txtGioiTinh.UnderlinedStyle = false;
            this.txtGioiTinh.UseSystemPasswordChar = false;
            // 
            // txtHonNhan
            // 
            this.txtHonNhan.BackColor = System.Drawing.Color.White;
            this.txtHonNhan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHonNhan.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtHonNhan.BorderSize = 1;
            this.txtHonNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHonNhan.IsNotSpace = false;
            this.txtHonNhan.Location = new System.Drawing.Point(379, 500);
            this.txtHonNhan.MaxLength = 12;
            this.txtHonNhan.Name = "txtHonNhan";
            this.txtHonNhan.Padding = new System.Windows.Forms.Padding(7);
            this.txtHonNhan.Size = new System.Drawing.Size(235, 36);
            this.txtHonNhan.TabIndex = 58;
            this.txtHonNhan.UnderlinedStyle = false;
            this.txtHonNhan.UseSystemPasswordChar = false;
            // 
            // txtVoChong
            // 
            this.txtVoChong.BackColor = System.Drawing.Color.White;
            this.txtVoChong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVoChong.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtVoChong.BorderSize = 1;
            this.txtVoChong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtVoChong.IsNotSpace = false;
            this.txtVoChong.Location = new System.Drawing.Point(217, 23);
            this.txtVoChong.MaxLength = 12;
            this.txtVoChong.Name = "txtVoChong";
            this.txtVoChong.Padding = new System.Windows.Forms.Padding(7);
            this.txtVoChong.Size = new System.Drawing.Size(275, 36);
            this.txtVoChong.TabIndex = 57;
            this.txtVoChong.UnderlinedStyle = false;
            this.txtVoChong.UseSystemPasswordChar = false;
            // 
            // txtNgheNghiep
            // 
            this.txtNgheNghiep.BackColor = System.Drawing.Color.White;
            this.txtNgheNghiep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNgheNghiep.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtNgheNghiep.BorderSize = 1;
            this.txtNgheNghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgheNghiep.IsNotSpace = false;
            this.txtNgheNghiep.Location = new System.Drawing.Point(338, 443);
            this.txtNgheNghiep.MaxLength = 12;
            this.txtNgheNghiep.Name = "txtNgheNghiep";
            this.txtNgheNghiep.Padding = new System.Windows.Forms.Padding(7);
            this.txtNgheNghiep.Size = new System.Drawing.Size(275, 36);
            this.txtNgheNghiep.TabIndex = 47;
            this.txtNgheNghiep.UnderlinedStyle = false;
            this.txtNgheNghiep.UseSystemPasswordChar = false;
            // 
            // txtHocVan
            // 
            this.txtHocVan.BackColor = System.Drawing.Color.White;
            this.txtHocVan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHocVan.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtHocVan.BorderSize = 1;
            this.txtHocVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHocVan.IsNotSpace = false;
            this.txtHocVan.Location = new System.Drawing.Point(314, 366);
            this.txtHocVan.MaxLength = 12;
            this.txtHocVan.Name = "txtHocVan";
            this.txtHocVan.Padding = new System.Windows.Forms.Padding(7);
            this.txtHocVan.Size = new System.Drawing.Size(300, 36);
            this.txtHocVan.TabIndex = 44;
            this.txtHocVan.UnderlinedStyle = false;
            this.txtHocVan.UseSystemPasswordChar = false;
            // 
            // txtHoTenMe
            // 
            this.txtHoTenMe.BackColor = System.Drawing.Color.White;
            this.txtHoTenMe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTenMe.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtHoTenMe.BorderSize = 1;
            this.txtHoTenMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenMe.IsNotSpace = false;
            this.txtHoTenMe.Location = new System.Drawing.Point(314, 293);
            this.txtHoTenMe.MaxLength = 12;
            this.txtHoTenMe.Name = "txtHoTenMe";
            this.txtHoTenMe.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTenMe.Size = new System.Drawing.Size(298, 36);
            this.txtHoTenMe.TabIndex = 41;
            this.txtHoTenMe.UnderlinedStyle = false;
            this.txtHoTenMe.UseSystemPasswordChar = false;
            this.txtHoTenMe.Load += new System.EventHandler(this.customTextBox1_Load);
            // 
            // txtHoTenBo
            // 
            this.txtHoTenBo.BackColor = System.Drawing.Color.White;
            this.txtHoTenBo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTenBo.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtHoTenBo.BorderSize = 1;
            this.txtHoTenBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTenBo.IsNotSpace = false;
            this.txtHoTenBo.Location = new System.Drawing.Point(314, 222);
            this.txtHoTenBo.MaxLength = 12;
            this.txtHoTenBo.Name = "txtHoTenBo";
            this.txtHoTenBo.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTenBo.Size = new System.Drawing.Size(299, 36);
            this.txtHoTenBo.TabIndex = 37;
            this.txtHoTenBo.UnderlinedStyle = false;
            this.txtHoTenBo.UseSystemPasswordChar = false;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.Color.White;
            this.txtHoTen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.Turquoise;
            this.txtHoTen.BorderSize = 1;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtHoTen.IsNotSpace = false;
            this.txtHoTen.Location = new System.Drawing.Point(314, 18);
            this.txtHoTen.MaxLength = 30;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.Size = new System.Drawing.Size(308, 36);
            this.txtHoTen.TabIndex = 36;
            this.txtHoTen.UnderlinedStyle = false;
            this.txtHoTen.UseSystemPasswordChar = false;
            this.txtHoTen.Load += new System.EventHandler(this.txtFullName_Load);
            // 
            // panelHonNhan
            // 
            this.panelHonNhan.Controls.Add(this.label10);
            this.panelHonNhan.Controls.Add(this.label9);
            this.panelHonNhan.Controls.Add(this.txtVoChong);
            this.panelHonNhan.Location = new System.Drawing.Point(122, 552);
            this.panelHonNhan.Name = "panelHonNhan";
            this.panelHonNhan.Size = new System.Drawing.Size(511, 78);
            this.panelHonNhan.TabIndex = 3;
            this.panelHonNhan.Visible = false;
            // 
            // ThongTinCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(758, 789);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongTinCaNhan";
            this.Text = "ThongTinCaNhan";
            this.Load += new System.EventHandler(this.ThongTinCaNhan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panelHonNhan.ResumeLayout(false);
            this.panelHonNhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelRes;
        private System.Windows.Forms.Panel panelForm;
        private customControls.CustomTextBox txtHoTenMe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private customControls.CustomTextBox txtHoTenBo;
        private customControls.CustomTextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpDateofBirth;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel1;
        private customControls.CustomTextBox txtNgheNghiep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private customControls.CustomTextBox txtHocVan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private customControls.CustomTextBox txtVoChong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private customControls.CustomTextBox txtHonNhan;
        private customControls.CustomTextBox txtGioiTinh;
        private System.Windows.Forms.Panel panelHonNhan;
    }
}
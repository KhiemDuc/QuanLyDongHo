namespace TodoApp
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnHome = new TodoApp.Controls.CustomButton();
            this.btnLogout = new TodoApp.Controls.CustomButton();
            this.btnQLTK = new TodoApp.Controls.CustomButton();
            this.customButton1 = new TodoApp.Controls.CustomButton();
            this.btnThongke = new TodoApp.Controls.CustomButton();
            this.btnQuanLySuKien = new TodoApp.Controls.CustomButton();
            this.btnThuChi = new TodoApp.Controls.CustomButton();
            this.btnThu = new TodoApp.Controls.CustomButton();
            this.btnChi = new TodoApp.Controls.CustomButton();
            this.btnThanhVien = new TodoApp.Controls.CustomButton();
            this.btnThem = new TodoApp.Controls.CustomButton();
            this.btnTaoCuTo = new TodoApp.Controls.CustomButton();
            this.btnDanhsach = new TodoApp.Controls.CustomButton();
            this.btnCaygiapha = new TodoApp.Controls.CustomButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnLogout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelContent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.53676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1482, 753);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.AutoSize = true;
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelFilter.Controls.Add(this.lblHeader);
            this.panelFilter.Controls.Add(this.panelUser);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(353, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1126, 114);
            this.panelFilter.TabIndex = 17;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(489, 66);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Text = "Dòng Họ Nhà Nguyễn Đức";
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.btnSetting);
            this.panelUser.Controls.Add(this.pictureBox2);
            this.panelUser.Controls.Add(this.lblUserName);
            this.panelUser.Location = new System.Drawing.Point(821, 9);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(272, 56);
            this.panelUser.TabIndex = 8;
            // 
            // btnSetting
            // 
            this.btnSetting.Image = global::TodoApp.Properties.Resources.icons8_info_24;
            this.btnSetting.Location = new System.Drawing.Point(231, 8);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(40, 35);
            this.btnSetting.TabIndex = 22;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUserName.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.Location = new System.Drawing.Point(30, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUserName.Size = new System.Drawing.Size(229, 31);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "UserName";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnQLTK);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 562);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnThongke);
            this.panel1.Controls.Add(this.btnQuanLySuKien);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 467);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 138);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.customButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(323, 138);
            this.panel3.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnThuChi);
            this.flowLayoutPanel2.Controls.Add(this.btnThu);
            this.flowLayoutPanel2.Controls.Add(this.btnChi);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 286);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(344, 181);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(344, 64);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(344, 181);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThanhVien);
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnTaoCuTo);
            this.flowLayoutPanel1.Controls.Add(this.btnDanhsach);
            this.flowLayoutPanel1.Controls.Add(this.btnCaygiapha);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(344, 286);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(344, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 286);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelContent.Location = new System.Drawing.Point(353, 123);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1126, 562);
            this.panelContent.TabIndex = 18;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnHome.BorderRadius = 0;
            this.btnHome.BorderSize = 0;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(344, 114);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnLogout.BorderRadius = 0;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::TodoApp.Properties.Resources.icons8_logout_rounded_32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 691);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(344, 59);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.TextColor = System.Drawing.Color.Black;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnQLTK
            // 
            this.btnQLTK.BackColor = System.Drawing.Color.Transparent;
            this.btnQLTK.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnQLTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQLTK.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnQLTK.BorderRadius = 0;
            this.btnQLTK.BorderSize = 0;
            this.btnQLTK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQLTK.FlatAppearance.BorderSize = 0;
            this.btnQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLTK.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQLTK.ForeColor = System.Drawing.Color.White;
            this.btnQLTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLTK.Location = new System.Drawing.Point(0, 605);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQLTK.Size = new System.Drawing.Size(323, 64);
            this.btnQLTK.TabIndex = 21;
            this.btnQLTK.Text = "Quản Lý Tài Khoản";
            this.btnQLTK.TextColor = System.Drawing.Color.White;
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customButton1.BorderColor = System.Drawing.Color.OrangeRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(0, 0);
            this.customButton1.Name = "customButton1";
            this.customButton1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.customButton1.Size = new System.Drawing.Size(323, 64);
            this.customButton1.TabIndex = 12;
            this.customButton1.Text = "Báo Cáo";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Transparent;
            this.btnThongke.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongke.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThongke.BorderRadius = 0;
            this.btnThongke.BorderSize = 0;
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 64);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(323, 64);
            this.btnThongke.TabIndex = 12;
            this.btnThongke.Text = "Báo Cáo";
            this.btnThongke.TextColor = System.Drawing.Color.White;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnQuanLySuKien
            // 
            this.btnQuanLySuKien.BackColor = System.Drawing.Color.Transparent;
            this.btnQuanLySuKien.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnQuanLySuKien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuanLySuKien.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnQuanLySuKien.BorderRadius = 0;
            this.btnQuanLySuKien.BorderSize = 0;
            this.btnQuanLySuKien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLySuKien.FlatAppearance.BorderSize = 0;
            this.btnQuanLySuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLySuKien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLySuKien.ForeColor = System.Drawing.Color.White;
            this.btnQuanLySuKien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLySuKien.Location = new System.Drawing.Point(0, 0);
            this.btnQuanLySuKien.Name = "btnQuanLySuKien";
            this.btnQuanLySuKien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQuanLySuKien.Size = new System.Drawing.Size(323, 64);
            this.btnQuanLySuKien.TabIndex = 13;
            this.btnQuanLySuKien.Text = "Quản Lý Sự Kiên";
            this.btnQuanLySuKien.TextColor = System.Drawing.Color.White;
            this.btnQuanLySuKien.UseVisualStyleBackColor = false;
            this.btnQuanLySuKien.Click += new System.EventHandler(this.btnQuanLySuKien_Click);
            // 
            // btnThuChi
            // 
            this.btnThuChi.BackColor = System.Drawing.Color.Transparent;
            this.btnThuChi.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThuChi.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThuChi.BorderRadius = 0;
            this.btnThuChi.BorderSize = 0;
            this.btnThuChi.FlatAppearance.BorderSize = 0;
            this.btnThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThuChi.ForeColor = System.Drawing.Color.Transparent;
            this.btnThuChi.Location = new System.Drawing.Point(3, 3);
            this.btnThuChi.Name = "btnThuChi";
            this.btnThuChi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThuChi.Size = new System.Drawing.Size(338, 64);
            this.btnThuChi.TabIndex = 16;
            this.btnThuChi.Text = "Quản Lý Thu Chi";
            this.btnThuChi.TextColor = System.Drawing.Color.Transparent;
            this.btnThuChi.UseVisualStyleBackColor = false;
            this.btnThuChi.Click += new System.EventHandler(this.btnThuChi_Click);
            // 
            // btnThu
            // 
            this.btnThu.BackColor = System.Drawing.Color.DimGray;
            this.btnThu.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThu.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThu.BorderRadius = 0;
            this.btnThu.BorderSize = 0;
            this.btnThu.FlatAppearance.BorderSize = 0;
            this.btnThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThu.ForeColor = System.Drawing.Color.Transparent;
            this.btnThu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThu.Location = new System.Drawing.Point(3, 73);
            this.btnThu.Name = "btnThu";
            this.btnThu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThu.Size = new System.Drawing.Size(338, 50);
            this.btnThu.TabIndex = 14;
            this.btnThu.Text = "Quản Lý Thu";
            this.btnThu.TextColor = System.Drawing.Color.Transparent;
            this.btnThu.UseVisualStyleBackColor = false;
            this.btnThu.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // btnChi
            // 
            this.btnChi.BackColor = System.Drawing.Color.DimGray;
            this.btnChi.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnChi.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnChi.BorderRadius = 0;
            this.btnChi.BorderSize = 0;
            this.btnChi.FlatAppearance.BorderSize = 0;
            this.btnChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChi.ForeColor = System.Drawing.Color.Transparent;
            this.btnChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChi.Location = new System.Drawing.Point(3, 129);
            this.btnChi.Name = "btnChi";
            this.btnChi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnChi.Size = new System.Drawing.Size(338, 50);
            this.btnChi.TabIndex = 15;
            this.btnChi.Text = "Quản Lý Chi";
            this.btnChi.TextColor = System.Drawing.Color.Transparent;
            this.btnChi.UseVisualStyleBackColor = false;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhVien.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThanhVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThanhVien.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThanhVien.BorderRadius = 0;
            this.btnThanhVien.BorderSize = 0;
            this.btnThanhVien.FlatAppearance.BorderSize = 0;
            this.btnThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhVien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThanhVien.ForeColor = System.Drawing.Color.White;
            this.btnThanhVien.Location = new System.Drawing.Point(3, 3);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThanhVien.Size = new System.Drawing.Size(338, 60);
            this.btnThanhVien.TabIndex = 16;
            this.btnThanhVien.Text = "Quản Lý Thành Viên";
            this.btnThanhVien.TextColor = System.Drawing.Color.White;
            this.btnThanhVien.UseVisualStyleBackColor = false;
            this.btnThanhVien.Click += new System.EventHandler(this.customButton1_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DimGray;
            this.btnThem.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThem.BorderRadius = 0;
            this.btnThem.BorderSize = 0;
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 69);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(338, 50);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm Thành Viên";
            this.btnThem.TextColor = System.Drawing.Color.White;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTaoCuTo
            // 
            this.btnTaoCuTo.BackColor = System.Drawing.Color.DimGray;
            this.btnTaoCuTo.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnTaoCuTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTaoCuTo.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnTaoCuTo.BorderRadius = 0;
            this.btnTaoCuTo.BorderSize = 0;
            this.btnTaoCuTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaoCuTo.FlatAppearance.BorderSize = 0;
            this.btnTaoCuTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoCuTo.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaoCuTo.ForeColor = System.Drawing.Color.White;
            this.btnTaoCuTo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaoCuTo.Location = new System.Drawing.Point(3, 125);
            this.btnTaoCuTo.Name = "btnTaoCuTo";
            this.btnTaoCuTo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTaoCuTo.Size = new System.Drawing.Size(338, 50);
            this.btnTaoCuTo.TabIndex = 9;
            this.btnTaoCuTo.Text = "Tạo Thông Tin Cụ Tổ";
            this.btnTaoCuTo.TextColor = System.Drawing.Color.White;
            this.btnTaoCuTo.UseVisualStyleBackColor = false;
            this.btnTaoCuTo.Click += new System.EventHandler(this.btnTaoCuTo_Click);
            // 
            // btnDanhsach
            // 
            this.btnDanhsach.BackColor = System.Drawing.Color.DimGray;
            this.btnDanhsach.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnDanhsach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDanhsach.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnDanhsach.BorderRadius = 0;
            this.btnDanhsach.BorderSize = 0;
            this.btnDanhsach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhsach.FlatAppearance.BorderSize = 0;
            this.btnDanhsach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhsach.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDanhsach.ForeColor = System.Drawing.Color.Transparent;
            this.btnDanhsach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhsach.Location = new System.Drawing.Point(3, 181);
            this.btnDanhsach.Name = "btnDanhsach";
            this.btnDanhsach.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDanhsach.Size = new System.Drawing.Size(338, 50);
            this.btnDanhsach.TabIndex = 11;
            this.btnDanhsach.Text = "Bảng Danh Sách";
            this.btnDanhsach.TextColor = System.Drawing.Color.Transparent;
            this.btnDanhsach.UseVisualStyleBackColor = false;
            this.btnDanhsach.Click += new System.EventHandler(this.btnDanhsach_Click);
            // 
            // btnCaygiapha
            // 
            this.btnCaygiapha.BackColor = System.Drawing.Color.DimGray;
            this.btnCaygiapha.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnCaygiapha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaygiapha.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnCaygiapha.BorderRadius = 0;
            this.btnCaygiapha.BorderSize = 0;
            this.btnCaygiapha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCaygiapha.FlatAppearance.BorderSize = 0;
            this.btnCaygiapha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaygiapha.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCaygiapha.ForeColor = System.Drawing.Color.White;
            this.btnCaygiapha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaygiapha.Location = new System.Drawing.Point(3, 237);
            this.btnCaygiapha.Name = "btnCaygiapha";
            this.btnCaygiapha.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCaygiapha.Size = new System.Drawing.Size(338, 50);
            this.btnCaygiapha.TabIndex = 10;
            this.btnCaygiapha.Text = "Cây Gia Phả";
            this.btnCaygiapha.TextColor = System.Drawing.Color.White;
            this.btnCaygiapha.UseVisualStyleBackColor = false;
            this.btnCaygiapha.Click += new System.EventHandler(this.btnCaygiapha_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1500, 753);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Homead_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserName;
        private Controls.CustomButton btnCaygiapha;
        private Controls.CustomButton btnTaoCuTo;
        private Controls.CustomButton btnThem;
        private Controls.CustomButton btnDanhsach;
        private System.Windows.Forms.Panel panel2;
        private Controls.CustomButton btnThanhVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.CustomButton btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Controls.CustomButton btnThuChi;
        private Controls.CustomButton btnThu;
        private Controls.CustomButton btnChi;
        private Controls.CustomButton btnQuanLySuKien;
        private Controls.CustomButton btnHome;
        private System.Windows.Forms.Panel panel1;
        private Controls.CustomButton btnQLTK;
        private System.Windows.Forms.Panel panel3;
        private Controls.CustomButton customButton1;
        private Controls.CustomButton btnThongke;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelContent;
    }
}
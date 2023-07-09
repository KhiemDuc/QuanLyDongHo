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
            this.panelQuanLy = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new TodoApp.Controls.CustomButton();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelThuChi = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThongke = new TodoApp.Controls.CustomButton();
            this.btnBaoCaoThuChi = new TodoApp.Controls.CustomButton();
            this.btnBieuDoThuChi = new TodoApp.Controls.CustomButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThanhVien = new TodoApp.Controls.CustomButton();
            this.btnThem = new TodoApp.Controls.CustomButton();
            this.btnTaoCuTo = new TodoApp.Controls.CustomButton();
            this.btnDanhsach = new TodoApp.Controls.CustomButton();
            this.btnCaygiapha = new TodoApp.Controls.CustomButton();
            this.btnThongKeSoBo = new TodoApp.Controls.CustomButton();
            this.btnQLTK = new TodoApp.Controls.CustomButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThuChi = new TodoApp.Controls.CustomButton();
            this.btnChi = new TodoApp.Controls.CustomButton();
            this.btnThu = new TodoApp.Controls.CustomButton();
            this.btnQuanLySuKien = new TodoApp.Controls.CustomButton();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new TodoApp.Controls.CustomButton();
            this.btnRename = new System.Windows.Forms.Button();
            this.panelQuanLy.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panelThuChi.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelQuanLy
            // 
            this.panelQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelQuanLy.ColumnCount = 2;
            this.panelQuanLy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 354F));
            this.panelQuanLy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelQuanLy.Controls.Add(this.btnHome, 0, 0);
            this.panelQuanLy.Controls.Add(this.panelFilter, 1, 0);
            this.panelQuanLy.Controls.Add(this.btnLogout, 0, 2);
            this.panelQuanLy.Controls.Add(this.panelContent, 1, 1);
            this.panelQuanLy.Controls.Add(this.panel1, 0, 1);
            this.panelQuanLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuanLy.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelQuanLy.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panelQuanLy.Location = new System.Drawing.Point(0, 0);
            this.panelQuanLy.Name = "panelQuanLy";
            this.panelQuanLy.RowCount = 3;
            this.panelQuanLy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.46325F));
            this.panelQuanLy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.53675F));
            this.panelQuanLy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.panelQuanLy.Size = new System.Drawing.Size(1482, 753);
            this.panelQuanLy.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
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
            this.btnHome.Size = new System.Drawing.Size(348, 114);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.TextColor = System.Drawing.Color.White;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.AutoSize = true;
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelFilter.Controls.Add(this.lblHeader);
            this.panelFilter.Controls.Add(this.panelUser);
            this.panelFilter.Controls.Add(this.btnRename);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFilter.Location = new System.Drawing.Point(357, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(1122, 114);
            this.panelFilter.TabIndex = 17;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblHeader.Location = new System.Drawing.Point(16, 16);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(0, 66);
            this.lblHeader.TabIndex = 16;
            this.lblHeader.Click += new System.EventHandler(this.lblHeader_Click);
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUser.Controls.Add(this.btnSetting);
            this.panelUser.Controls.Add(this.pictureBox2);
            this.panelUser.Controls.Add(this.lblUserName);
            this.panelUser.Location = new System.Drawing.Point(825, 16);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(272, 56);
            this.panelUser.TabIndex = 8;
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
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panelContent.Location = new System.Drawing.Point(357, 123);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1122, 562);
            this.panelContent.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 562);
            this.panel1.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel3.Controls.Add(this.panelThuChi);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel3.Controls.Add(this.btnQLTK);
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel3.Controls.Add(this.btnQuanLySuKien);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(348, 562);
            this.flowLayoutPanel3.TabIndex = 19;
            // 
            // panelThuChi
            // 
            this.panelThuChi.Controls.Add(this.btnThongke);
            this.panelThuChi.Controls.Add(this.btnBaoCaoThuChi);
            this.panelThuChi.Controls.Add(this.btnBieuDoThuChi);
            this.panelThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelThuChi.Location = new System.Drawing.Point(3, 3);
            this.panelThuChi.MaximumSize = new System.Drawing.Size(341, 175);
            this.panelThuChi.MinimumSize = new System.Drawing.Size(341, 64);
            this.panelThuChi.Name = "panelThuChi";
            this.panelThuChi.Size = new System.Drawing.Size(341, 175);
            this.panelThuChi.TabIndex = 0;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Transparent;
            this.btnThongke.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongke.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThongke.BorderRadius = 0;
            this.btnThongke.BorderSize = 0;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(3, 3);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(338, 60);
            this.btnThongke.TabIndex = 12;
            this.btnThongke.Text = "Thống Kê";
            this.btnThongke.TextColor = System.Drawing.Color.White;
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnBaoCaoThuChi
            // 
            this.btnBaoCaoThuChi.BackColor = System.Drawing.Color.DimGray;
            this.btnBaoCaoThuChi.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnBaoCaoThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBaoCaoThuChi.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnBaoCaoThuChi.BorderRadius = 0;
            this.btnBaoCaoThuChi.BorderSize = 0;
            this.btnBaoCaoThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaoCaoThuChi.FlatAppearance.BorderSize = 0;
            this.btnBaoCaoThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaoCaoThuChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCaoThuChi.ForeColor = System.Drawing.Color.White;
            this.btnBaoCaoThuChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCaoThuChi.Location = new System.Drawing.Point(3, 69);
            this.btnBaoCaoThuChi.Name = "btnBaoCaoThuChi";
            this.btnBaoCaoThuChi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBaoCaoThuChi.Size = new System.Drawing.Size(338, 50);
            this.btnBaoCaoThuChi.TabIndex = 13;
            this.btnBaoCaoThuChi.Text = "Báo Cáo Thu Chi";
            this.btnBaoCaoThuChi.TextColor = System.Drawing.Color.White;
            this.btnBaoCaoThuChi.UseVisualStyleBackColor = false;
            this.btnBaoCaoThuChi.Click += new System.EventHandler(this.btnBaoCaoThuChi_Click);
            // 
            // btnBieuDoThuChi
            // 
            this.btnBieuDoThuChi.BackColor = System.Drawing.Color.DimGray;
            this.btnBieuDoThuChi.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnBieuDoThuChi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBieuDoThuChi.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnBieuDoThuChi.BorderRadius = 0;
            this.btnBieuDoThuChi.BorderSize = 0;
            this.btnBieuDoThuChi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBieuDoThuChi.FlatAppearance.BorderSize = 0;
            this.btnBieuDoThuChi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBieuDoThuChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBieuDoThuChi.ForeColor = System.Drawing.Color.White;
            this.btnBieuDoThuChi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBieuDoThuChi.Location = new System.Drawing.Point(3, 125);
            this.btnBieuDoThuChi.Name = "btnBieuDoThuChi";
            this.btnBieuDoThuChi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnBieuDoThuChi.Size = new System.Drawing.Size(338, 50);
            this.btnBieuDoThuChi.TabIndex = 15;
            this.btnBieuDoThuChi.Text = "Biểu Đồ Thu Chi";
            this.btnBieuDoThuChi.TextColor = System.Drawing.Color.White;
            this.btnBieuDoThuChi.UseVisualStyleBackColor = false;
            this.btnBieuDoThuChi.Click += new System.EventHandler(this.btnBieuDoThuChi_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Controls.Add(this.btnThanhVien);
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnTaoCuTo);
            this.flowLayoutPanel1.Controls.Add(this.btnDanhsach);
            this.flowLayoutPanel1.Controls.Add(this.btnCaygiapha);
            this.flowLayoutPanel1.Controls.Add(this.btnThongKeSoBo);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 184);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(344, 346);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(344, 60);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 346);
            this.flowLayoutPanel1.TabIndex = 17;
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
            this.btnThem.MaximumSize = new System.Drawing.Size(338, 50);
            this.btnThem.MinimumSize = new System.Drawing.Size(338, 50);
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
            this.btnTaoCuTo.MaximumSize = new System.Drawing.Size(338, 50);
            this.btnTaoCuTo.MinimumSize = new System.Drawing.Size(338, 50);
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
            this.btnDanhsach.MaximumSize = new System.Drawing.Size(338, 50);
            this.btnDanhsach.MinimumSize = new System.Drawing.Size(338, 50);
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
            this.btnCaygiapha.MaximumSize = new System.Drawing.Size(338, 50);
            this.btnCaygiapha.MinimumSize = new System.Drawing.Size(338, 50);
            this.btnCaygiapha.Name = "btnCaygiapha";
            this.btnCaygiapha.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCaygiapha.Size = new System.Drawing.Size(338, 50);
            this.btnCaygiapha.TabIndex = 10;
            this.btnCaygiapha.Text = "Cây Gia Phả";
            this.btnCaygiapha.TextColor = System.Drawing.Color.White;
            this.btnCaygiapha.UseVisualStyleBackColor = false;
            this.btnCaygiapha.Click += new System.EventHandler(this.btnCaygiapha_Click);
            // 
            // btnThongKeSoBo
            // 
            this.btnThongKeSoBo.BackColor = System.Drawing.Color.DimGray;
            this.btnThongKeSoBo.BackgroundColor = System.Drawing.Color.DimGray;
            this.btnThongKeSoBo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThongKeSoBo.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnThongKeSoBo.BorderRadius = 0;
            this.btnThongKeSoBo.BorderSize = 0;
            this.btnThongKeSoBo.FlatAppearance.BorderSize = 0;
            this.btnThongKeSoBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKeSoBo.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThongKeSoBo.ForeColor = System.Drawing.Color.White;
            this.btnThongKeSoBo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKeSoBo.Location = new System.Drawing.Point(3, 293);
            this.btnThongKeSoBo.MaximumSize = new System.Drawing.Size(338, 50);
            this.btnThongKeSoBo.MinimumSize = new System.Drawing.Size(338, 50);
            this.btnThongKeSoBo.Name = "btnThongKeSoBo";
            this.btnThongKeSoBo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThongKeSoBo.Size = new System.Drawing.Size(338, 50);
            this.btnThongKeSoBo.TabIndex = 14;
            this.btnThongKeSoBo.Text = "Thống Kê Sơ Bộ";
            this.btnThongKeSoBo.TextColor = System.Drawing.Color.White;
            this.btnThongKeSoBo.UseVisualStyleBackColor = false;
            this.btnThongKeSoBo.Click += new System.EventHandler(this.btnThongKeSoBo_Click);
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
            this.btnQLTK.Location = new System.Drawing.Point(3, 536);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQLTK.Size = new System.Drawing.Size(338, 64);
            this.btnQLTK.TabIndex = 21;
            this.btnQLTK.Text = "Quản Lý Tài Khoản";
            this.btnQLTK.TextColor = System.Drawing.Color.White;
            this.btnQLTK.UseVisualStyleBackColor = false;
            this.btnQLTK.Click += new System.EventHandler(this.btnQLTK_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnThuChi);
            this.flowLayoutPanel2.Controls.Add(this.btnChi);
            this.flowLayoutPanel2.Controls.Add(this.btnThu);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 606);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(342, 188);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(342, 60);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(342, 188);
            this.flowLayoutPanel2.TabIndex = 22;
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
            this.btnChi.Location = new System.Drawing.Point(3, 73);
            this.btnChi.Name = "btnChi";
            this.btnChi.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnChi.Size = new System.Drawing.Size(338, 50);
            this.btnChi.TabIndex = 15;
            this.btnChi.Text = "Quản Lý Chi";
            this.btnChi.TextColor = System.Drawing.Color.Transparent;
            this.btnChi.UseVisualStyleBackColor = false;
            this.btnChi.Click += new System.EventHandler(this.btnChi_Click);
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
            this.btnThu.Location = new System.Drawing.Point(3, 129);
            this.btnThu.Name = "btnThu";
            this.btnThu.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnThu.Size = new System.Drawing.Size(338, 50);
            this.btnThu.TabIndex = 14;
            this.btnThu.Text = "Quản Lý Thu";
            this.btnThu.TextColor = System.Drawing.Color.Transparent;
            this.btnThu.UseVisualStyleBackColor = false;
            this.btnThu.Click += new System.EventHandler(this.customButton1_Click);
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
            this.btnQuanLySuKien.Location = new System.Drawing.Point(3, 800);
            this.btnQuanLySuKien.Name = "btnQuanLySuKien";
            this.btnQuanLySuKien.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnQuanLySuKien.Size = new System.Drawing.Size(338, 50);
            this.btnQuanLySuKien.TabIndex = 13;
            this.btnQuanLySuKien.Text = "Quản Lý Sự Kiên";
            this.btnQuanLySuKien.TextColor = System.Drawing.Color.White;
            this.btnQuanLySuKien.UseVisualStyleBackColor = false;
            this.btnQuanLySuKien.Click += new System.EventHandler(this.btnQuanLySuKien_Click);
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
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(693, 25);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(108, 37);
            this.btnRename.TabIndex = 20;
            this.btnRename.Text = "Thay tên";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.panelQuanLy);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1500, 753);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Homead_Load);
            this.panelQuanLy.ResumeLayout(false);
            this.panelQuanLy.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panelThuChi.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel panelQuanLy;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserName;
        private Controls.CustomButton btnCaygiapha;
        private Controls.CustomButton btnTaoCuTo;
        private Controls.CustomButton btnThem;
        private Controls.CustomButton btnDanhsach;
        private Controls.CustomButton btnThanhVien;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Controls.CustomButton btnLogout;
        private Controls.CustomButton btnThuChi;
        private Controls.CustomButton btnThu;
        private Controls.CustomButton btnChi;
        private Controls.CustomButton btnQuanLySuKien;
        private Controls.CustomButton btnHome;
        private Controls.CustomButton btnQLTK;
        private Controls.CustomButton btnThongke;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel panelThuChi;
        private Controls.CustomButton btnBaoCaoThuChi;
        private Controls.CustomButton btnThongKeSoBo;
        private Controls.CustomButton btnBieuDoThuChi;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRename;
    }
}
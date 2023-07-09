namespace TodoApp
{
    partial class QuanLyChiTieu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongChiTieu = new System.Windows.Forms.Label();
            this.dgvDanhSachChiTieu = new System.Windows.Forms.DataGridView();
            this.TenKhoanChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnThietLapChi = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTieu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachChiTieu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.42308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.57692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1394, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTongChiTieu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 541);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 97);
            this.panel2.TabIndex = 40;
            // 
            // lblTongChiTieu
            // 
            this.lblTongChiTieu.AutoSize = true;
            this.lblTongChiTieu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongChiTieu.Location = new System.Drawing.Point(568, 37);
            this.lblTongChiTieu.Name = "lblTongChiTieu";
            this.lblTongChiTieu.Size = new System.Drawing.Size(0, 34);
            this.lblTongChiTieu.TabIndex = 4;
            // 
            // dgvDanhSachChiTieu
            // 
            this.dgvDanhSachChiTieu.AllowUserToAddRows = false;
            this.dgvDanhSachChiTieu.AllowUserToDeleteRows = false;
            this.dgvDanhSachChiTieu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachChiTieu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDanhSachChiTieu.ColumnHeadersHeight = 100;
            this.dgvDanhSachChiTieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhoanChi,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.SoTien,
            this.MoTa,
            this.Sua,
            this.ChiTiet,
            this.Xoa,
            this.MaChi});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachChiTieu.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDanhSachChiTieu.Location = new System.Drawing.Point(3, 134);
            this.dgvDanhSachChiTieu.Name = "dgvDanhSachChiTieu";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachChiTieu.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhSachChiTieu.RowHeadersWidth = 51;
            this.dgvDanhSachChiTieu.RowTemplate.Height = 24;
            this.dgvDanhSachChiTieu.Size = new System.Drawing.Size(1388, 401);
            this.dgvDanhSachChiTieu.TabIndex = 1;
            this.dgvDanhSachChiTieu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThu_CellContentClick);
            // 
            // TenKhoanChi
            // 
            dataGridViewCellStyle10.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenKhoanChi.DefaultCellStyle = dataGridViewCellStyle10;
            this.TenKhoanChi.HeaderText = "Tên Khoản Chi";
            this.TenKhoanChi.MinimumWidth = 6;
            this.TenKhoanChi.Name = "TenKhoanChi";
            this.TenKhoanChi.Width = 250;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.HeaderText = "Ngày Bắt Đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 180;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.HeaderText = "Ngày Kết Thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 180;
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Số Tiền (VND)";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            // 
            // Sua
            // 
            this.Sua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            this.Sua.Width = 55;
            // 
            // ChiTiet
            // 
            this.ChiTiet.HeaderText = "Chi Tiết";
            this.ChiTiet.MinimumWidth = 6;
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Text = "Chi Tiết";
            this.ChiTiet.UseColumnTextForButtonValue = true;
            this.ChiTiet.Width = 125;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            this.Xoa.Width = 56;
            // 
            // MaChi
            // 
            this.MaChi.HeaderText = "Mã Chi";
            this.MaChi.MinimumWidth = 6;
            this.MaChi.Name = "MaChi";
            this.MaChi.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.btnThietLapChi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1388, 125);
            this.panel1.TabIndex = 0;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayBatDau.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.CustomFormat = "  dd/ MM/ yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(790, 48);
            this.dtpNgayBatDau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(176, 28);
            this.dtpNgayBatDau.TabIndex = 52;
            this.dtpNgayBatDau.Value = new System.DateTime(2002, 1, 1, 14, 57, 0, 0);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNgayKetThuc.CalendarFont = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.CustomFormat = "  dd/ MM/ yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(1078, 47);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(183, 28);
            this.dtpNgayKetThuc.TabIndex = 53;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.Location = new System.Drawing.Point(1278, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 31);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Xem";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(985, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Đến Ngày";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUser.Location = new System.Drawing.Point(708, 50);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 29);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "Từ Ngày";
            // 
            // btnThietLapChi
            // 
            this.btnThietLapChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThietLapChi.Location = new System.Drawing.Point(15, 46);
            this.btnThietLapChi.Name = "btnThietLapChi";
            this.btnThietLapChi.Size = new System.Drawing.Size(297, 38);
            this.btnThietLapChi.TabIndex = 33;
            this.btnThietLapChi.Text = "Thêm Khoản Chi";
            this.btnThietLapChi.UseVisualStyleBackColor = true;
            this.btnThietLapChi.Click += new System.EventHandler(this.btnThietLapChi_Click);
            // 
            // QuanLyChiTieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 641);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "QuanLyChiTieu";
            this.Text = "QuanLyChiTieu";
            this.Load += new System.EventHandler(this.QuanLyChiTieu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachChiTieu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThietLapChi;
        private System.Windows.Forms.DataGridView dgvDanhSachChiTieu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTongChiTieu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoanChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTiet;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChi;
    }
}
namespace TodoApp
{
    partial class QuanLySuKien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhSachSuKien = new System.Windows.Forms.DataGridView();
            this.MaSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSuKien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayToChuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChiTieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTietChiTieu = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThietLapChi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSuKien)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 567);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachSuKien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1392, 567);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvDanhSachSuKien
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachSuKien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSuKien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDanhSachSuKien.ColumnHeadersHeight = 100;
            this.dgvDanhSachSuKien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSuKien,
            this.TenSuKien,
            this.NgayToChuc,
            this.MaChi,
            this.DiaDiem,
            this.TenChiTieu,
            this.ChiTietChiTieu,
            this.Sua,
            this.Xoa});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSuKien.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDanhSachSuKien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachSuKien.Location = new System.Drawing.Point(3, 144);
            this.dgvDanhSachSuKien.Name = "dgvDanhSachSuKien";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSuKien.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhSachSuKien.RowHeadersWidth = 60;
            this.dgvDanhSachSuKien.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachSuKien.RowTemplate.Height = 30;
            this.dgvDanhSachSuKien.Size = new System.Drawing.Size(1386, 420);
            this.dgvDanhSachSuKien.TabIndex = 1;
            this.dgvDanhSachSuKien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSuKien_CellContentClick);
            this.dgvDanhSachSuKien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDanhSachSuKien_CellFormatting);
            // 
            // MaSuKien
            // 
            this.MaSuKien.HeaderText = "Mã Sự Kiện";
            this.MaSuKien.MinimumWidth = 6;
            this.MaSuKien.Name = "MaSuKien";
            this.MaSuKien.Width = 125;
            // 
            // TenSuKien
            // 
            this.TenSuKien.HeaderText = "Tên Sự Kiện";
            this.TenSuKien.MinimumWidth = 6;
            this.TenSuKien.Name = "TenSuKien";
            this.TenSuKien.Width = 250;
            // 
            // NgayToChuc
            // 
            this.NgayToChuc.HeaderText = "Ngày Tổ Chức";
            this.NgayToChuc.MinimumWidth = 6;
            this.NgayToChuc.Name = "NgayToChuc";
            this.NgayToChuc.Width = 160;
            // 
            // MaChi
            // 
            this.MaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaChi.HeaderText = "Mã Chi";
            this.MaChi.MinimumWidth = 6;
            this.MaChi.Name = "MaChi";
            this.MaChi.Visible = false;
            // 
            // DiaDiem
            // 
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.MinimumWidth = 6;
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.Width = 200;
            // 
            // TenChiTieu
            // 
            this.TenChiTieu.HeaderText = "Tên Chi Tiêu";
            this.TenChiTieu.MinimumWidth = 6;
            this.TenChiTieu.Name = "TenChiTieu";
            this.TenChiTieu.Width = 200;
            // 
            // ChiTietChiTieu
            // 
            this.ChiTietChiTieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChiTietChiTieu.HeaderText = "Chi Tiết Chi Tiêu";
            this.ChiTietChiTieu.MinimumWidth = 6;
            this.ChiTietChiTieu.Name = "ChiTietChiTieu";
            this.ChiTietChiTieu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ChiTietChiTieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ChiTietChiTieu.Text = "Chi Tiết";
            this.ChiTietChiTieu.UseColumnTextForButtonValue = true;
            // 
            // Sua
            // 
            this.Sua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sua.HeaderText = "Chi Tiết Sự Kiện";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sua.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sua.Text = "Chi Tiết";
            this.Sua.UseColumnTextForButtonValue = true;
            // 
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTimKiem);
            this.panel2.Controls.Add(this.dtpNgayBatDau);
            this.panel2.Controls.Add(this.dtpNgayKetThuc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.btnThietLapChi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1386, 135);
            this.panel2.TabIndex = 0;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimKiem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Location = new System.Drawing.Point(913, 65);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(82, 32);
            this.btnTimKiem.TabIndex = 54;
            this.btnTimKiem.Text = "Xem";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayBatDau.CustomFormat = "  dd/ MM/ yyyy";
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(435, 67);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(171, 28);
            this.dtpNgayBatDau.TabIndex = 53;
            this.dtpNgayBatDau.Value = new System.DateTime(2000, 1, 1, 0, 2, 0, 0);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayKetThuc.CustomFormat = "  dd/ MM/ yyyy";
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(725, 68);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(171, 28);
            this.dtpNgayKetThuc.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(632, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 51;
            this.label4.Text = "Đến Ngày";
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUser.Location = new System.Drawing.Point(353, 68);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 29);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "Từ Ngày";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackgroundImage = global::TodoApp.Properties.Resources.icons8_search_641;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(1322, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 39);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1049, 64);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(255, 34);
            this.txtSearch.TabIndex = 36;
            // 
            // btnThietLapChi
            // 
            this.btnThietLapChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThietLapChi.Location = new System.Drawing.Point(9, 59);
            this.btnThietLapChi.Name = "btnThietLapChi";
            this.btnThietLapChi.Size = new System.Drawing.Size(297, 38);
            this.btnThietLapChi.TabIndex = 33;
            this.btnThietLapChi.Text = "Thêm Sự Kiện";
            this.btnThietLapChi.UseVisualStyleBackColor = true;
            this.btnThietLapChi.Click += new System.EventHandler(this.btnThietLapChi_Click);
            // 
            // QuanLySuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1392, 567);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLySuKien";
            this.Text = "QuanLySuKien";
            this.Load += new System.EventHandler(this.QuanLySuKien_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSuKien)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhSachSuKien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThietLapChi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayToChuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChiTieu;
        private System.Windows.Forms.DataGridViewButtonColumn ChiTietChiTieu;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
    }
}
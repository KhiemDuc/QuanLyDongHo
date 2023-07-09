namespace TodoApp
{
    partial class ChiTietKhoanThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhSachThuChiTiet = new System.Windows.Forms.DataGridView();
            this.TenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaGiaoDichThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuChiTiet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachThuChiTiet, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.47448F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.52552F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1375, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // dgvDanhSachThuChiTiet
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThuChiTiet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachThuChiTiet.ColumnHeadersHeight = 100;
            this.dgvDanhSachThuChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThanhVien,
            this.NgayThu,
            this.SoTien,
            this.TrangThai,
            this.TenThu,
            this.Sua,
            this.MaGiaoDichThu});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachThuChiTiet.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDanhSachThuChiTiet.Location = new System.Drawing.Point(3, 3);
            this.dgvDanhSachThuChiTiet.Name = "dgvDanhSachThuChiTiet";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThuChiTiet.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDanhSachThuChiTiet.RowHeadersWidth = 51;
            this.dgvDanhSachThuChiTiet.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvDanhSachThuChiTiet.RowTemplate.Height = 24;
            this.dgvDanhSachThuChiTiet.Size = new System.Drawing.Size(1369, 425);
            this.dgvDanhSachThuChiTiet.TabIndex = 2;
            this.dgvDanhSachThuChiTiet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThuChiTiet_CellContentClick);
            // 
            // TenThanhVien
            // 
            this.TenThanhVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenThanhVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.TenThanhVien.HeaderText = "Tên Thành Viên";
            this.TenThanhVien.MinimumWidth = 6;
            this.TenThanhVien.Name = "TenThanhVien";
            // 
            // NgayThu
            // 
            this.NgayThu.HeaderText = "Ngày Thu";
            this.NgayThu.MinimumWidth = 6;
            this.NgayThu.Name = "NgayThu";
            this.NgayThu.Width = 180;
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Số Tiền (VND)";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 125;
            // 
            // TrangThai
            // 
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 125;
            // 
            // TenThu
            // 
            this.TenThu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenThu.HeaderText = "Tên Thu";
            this.TenThu.MinimumWidth = 6;
            this.TenThu.Name = "TenThu";
            // 
            // Sua
            // 
            this.Sua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sua.HeaderText = "Sửa";
            this.Sua.MinimumWidth = 6;
            this.Sua.Name = "Sua";
            this.Sua.Text = "Sửa";
            this.Sua.UseColumnTextForButtonValue = true;
            // 
            // MaGiaoDichThu
            // 
            this.MaGiaoDichThu.HeaderText = "Mã Giao Dịch";
            this.MaGiaoDichThu.MinimumWidth = 6;
            this.MaGiaoDichThu.Name = "MaGiaoDichThu";
            this.MaGiaoDichThu.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTongThu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 434);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1369, 92);
            this.panel1.TabIndex = 3;
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTongThu.Location = new System.Drawing.Point(567, 39);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(0, 29);
            this.lblTongThu.TabIndex = 0;
            // 
            // ChiTietKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChiTietKhoanThu";
            this.Text = "Chi Tiết Khoản Thu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChiTietKhoanThu_FormClosed);
            this.Load += new System.EventHandler(this.ChiTietKhoanThu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuChiTiet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhSachThuChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThu;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGiaoDichThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTongThu;
    }
}
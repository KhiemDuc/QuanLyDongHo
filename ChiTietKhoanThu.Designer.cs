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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDanhSachThu = new System.Windows.Forms.DataGridView();
            this.TenKhoanThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DinhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhSachThu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhoanThu,
            this.NgayBatDauThu,
            this.DinhMuc,
            this.DanhMuc,
            this.MoTa,
            this.Sua,
            this.Xoa,
            this.MaThanhVien});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachThu.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSachThu.Name = "dgvDanhSachThu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachThu.RowHeadersWidth = 51;
            this.dgvDanhSachThu.RowTemplate.Height = 24;
            this.dgvDanhSachThu.Size = new System.Drawing.Size(1409, 529);
            this.dgvDanhSachThu.TabIndex = 1;
            this.dgvDanhSachThu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThu_CellContentClick);
            // 
            // TenKhoanThu
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenKhoanThu.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenKhoanThu.HeaderText = "Tên Khoản Thu";
            this.TenKhoanThu.MinimumWidth = 6;
            this.TenKhoanThu.Name = "TenKhoanThu";
            this.TenKhoanThu.Width = 250;
            // 
            // NgayBatDauThu
            // 
            this.NgayBatDauThu.HeaderText = "Ngày Bắt Đầu Thu";
            this.NgayBatDauThu.MinimumWidth = 6;
            this.NgayBatDauThu.Name = "NgayBatDauThu";
            this.NgayBatDauThu.Width = 180;
            // 
            // DinhMuc
            // 
            this.DinhMuc.HeaderText = "Định Mức";
            this.DinhMuc.MinimumWidth = 6;
            this.DinhMuc.Name = "DinhMuc";
            this.DinhMuc.Width = 125;
            // 
            // DanhMuc
            // 
            this.DanhMuc.HeaderText = "Trạng Thái";
            this.DanhMuc.MinimumWidth = 6;
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 300;
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
            // Xoa
            // 
            this.Xoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // MaThanhVien
            // 
            this.MaThanhVien.HeaderText = "Mã Thành Viên";
            this.MaThanhVien.MinimumWidth = 6;
            this.MaThanhVien.Name = "MaThanhVien";
            this.MaThanhVien.Width = 125;
            // 
            // ChiTietKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 529);
            this.Controls.Add(this.dgvDanhSachThu);
            this.Name = "ChiTietKhoanThu";
            this.Text = "Chi Tiết Khoản Thu";
            this.Load += new System.EventHandler(this.ChiTietKhoanThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoanThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DinhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThanhVien;
    }
}
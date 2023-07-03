namespace TodoApp
{
    partial class ChiTietKhoanChi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhSachThu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThietLapChi = new System.Windows.Forms.Button();
            this.TenKhoanChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.MaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDanhSachThu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.42308F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.57692F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1407, 480);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dgvDanhSachThu
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachThu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenKhoanChi,
            this.TenThanhVien,
            this.NgayChi,
            this.SoTien,
            this.Sua,
            this.Xoa,
            this.MaChi});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachThu.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachThu.Location = new System.Drawing.Point(3, 95);
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
            this.dgvDanhSachThu.Size = new System.Drawing.Size(1401, 279);
            this.dgvDanhSachThu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThietLapChi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 86);
            this.panel1.TabIndex = 0;
            // 
            // btnThietLapChi
            // 
            this.btnThietLapChi.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThietLapChi.Location = new System.Drawing.Point(15, 24);
            this.btnThietLapChi.Name = "btnThietLapChi";
            this.btnThietLapChi.Size = new System.Drawing.Size(297, 38);
            this.btnThietLapChi.TabIndex = 33;
            this.btnThietLapChi.Text = "Thêm Khoản Chi Cụ Thể";
            this.btnThietLapChi.UseVisualStyleBackColor = true;
            this.btnThietLapChi.Click += new System.EventHandler(this.btnThietLapChi_Click);
            // 
            // TenKhoanChi
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TenKhoanChi.DefaultCellStyle = dataGridViewCellStyle2;
            this.TenKhoanChi.HeaderText = "Tên Khoản Chi Cụ Thể";
            this.TenKhoanChi.MinimumWidth = 6;
            this.TenKhoanChi.Name = "TenKhoanChi";
            this.TenKhoanChi.Width = 250;
            // 
            // TenThanhVien
            // 
            this.TenThanhVien.HeaderText = "Tên Thành Viên";
            this.TenThanhVien.MinimumWidth = 6;
            this.TenThanhVien.Name = "TenThanhVien";
            this.TenThanhVien.Width = 200;
            // 
            // NgayChi
            // 
            this.NgayChi.HeaderText = "Ngày Chi";
            this.NgayChi.MinimumWidth = 6;
            this.NgayChi.Name = "NgayChi";
            this.NgayChi.Width = 180;
            // 
            // SoTien
            // 
            this.SoTien.HeaderText = "Số Tiền";
            this.SoTien.MinimumWidth = 6;
            this.SoTien.Name = "SoTien";
            this.SoTien.Width = 125;
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
            // MaChi
            // 
            this.MaChi.HeaderText = "Mã Chi";
            this.MaChi.MinimumWidth = 6;
            this.MaChi.Name = "MaChi";
            this.MaChi.Width = 125;
            // 
            // ChiTietKhoanChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 480);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChiTietKhoanChi";
            this.Text = "ChiTietKhoanChi";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvDanhSachThu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThietLapChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoanChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTien;
        private System.Windows.Forms.DataGridViewButtonColumn Sua;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChi;
    }
}
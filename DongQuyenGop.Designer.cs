namespace TodoApp
{
    partial class DongQuyenGop
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
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.cmbQuyenGop = new System.Windows.Forms.ComboBox();
            this.cmbThanhVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(247, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(302, 49);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(149, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 34);
            this.label3.TabIndex = 27;
            this.label3.Text = "Ngày Thu";
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayThu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThu.Location = new System.Drawing.Point(386, 283);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(274, 37);
            this.dtpNgayThu.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(149, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 34);
            this.label2.TabIndex = 25;
            this.label2.Text = "Số Tiền";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(149, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 24;
            this.label1.Text = "Chọn Loại Quyên Góp";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoTien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoTien.Location = new System.Drawing.Point(386, 208);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(274, 37);
            this.txtSoTien.TabIndex = 23;
            // 
            // cmbQuyenGop
            // 
            this.cmbQuyenGop.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbQuyenGop.FormattingEnabled = true;
            this.cmbQuyenGop.Location = new System.Drawing.Point(386, 145);
            this.cmbQuyenGop.Name = "cmbQuyenGop";
            this.cmbQuyenGop.Size = new System.Drawing.Size(203, 39);
            this.cmbQuyenGop.TabIndex = 31;
            // 
            // cmbThanhVien
            // 
            this.cmbThanhVien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbThanhVien.FormattingEnabled = true;
            this.cmbThanhVien.Location = new System.Drawing.Point(386, 71);
            this.cmbThanhVien.Name = "cmbThanhVien";
            this.cmbThanhVien.Size = new System.Drawing.Size(203, 39);
            this.cmbThanhVien.TabIndex = 33;
            this.cmbThanhVien.SelectedIndexChanged += new System.EventHandler(this.cmbThanhVien_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(149, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 34);
            this.label4.TabIndex = 32;
            this.label4.Text = "Chọn Thành Viên";
            // 
            // DongQuyenGop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 492);
            this.Controls.Add(this.cmbThanhVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbQuyenGop);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoTien);
            this.Name = "DongQuyenGop";
            this.Text = "DongQuyenGop";
            this.Load += new System.EventHandler(this.DongQuyenGop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.ComboBox cmbQuyenGop;
        private System.Windows.Forms.ComboBox cmbThanhVien;
        private System.Windows.Forms.Label label4;
    }
}
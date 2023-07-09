namespace TodoApp
{
    partial class ThemSuaKhoanThu
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
            this.txtTenKhoanThu = new System.Windows.Forms.TextBox();
            this.txtDinhMuc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDinhMuc = new System.Windows.Forms.Label();
            this.dtpBatDau = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLoaiThu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTenKhoanThu
            // 
            this.txtTenKhoanThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenKhoanThu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenKhoanThu.Location = new System.Drawing.Point(339, 71);
            this.txtTenKhoanThu.Name = "txtTenKhoanThu";
            this.txtTenKhoanThu.Size = new System.Drawing.Size(274, 37);
            this.txtTenKhoanThu.TabIndex = 0;
            // 
            // txtDinhMuc
            // 
            this.txtDinhMuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDinhMuc.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDinhMuc.Location = new System.Drawing.Point(339, 130);
            this.txtDinhMuc.Name = "txtDinhMuc";
            this.txtDinhMuc.Size = new System.Drawing.Size(274, 37);
            this.txtDinhMuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(102, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Khoản Thu";
            // 
            // lblDinhMuc
            // 
            this.lblDinhMuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDinhMuc.AutoSize = true;
            this.lblDinhMuc.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDinhMuc.Location = new System.Drawing.Point(102, 130);
            this.lblDinhMuc.Name = "lblDinhMuc";
            this.lblDinhMuc.Size = new System.Drawing.Size(100, 34);
            this.lblDinhMuc.TabIndex = 3;
            this.lblDinhMuc.Text = "ĐỊnh Mức";
            // 
            // dtpBatDau
            // 
            this.dtpBatDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpBatDau.CustomFormat = "   dd/ MM/ yyyy";
            this.dtpBatDau.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBatDau.Location = new System.Drawing.Point(339, 201);
            this.dtpBatDau.Name = "dtpBatDau";
            this.dtpBatDau.Size = new System.Drawing.Size(183, 27);
            this.dtpBatDau.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(102, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày Bắt Đầu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(102, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Loại Thu";
            // 
            // cmbLoaiThu
            // 
            this.cmbLoaiThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLoaiThu.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiThu.FormattingEnabled = true;
            this.cmbLoaiThu.Items.AddRange(new object[] {
            "Định Mức",
            "Tài Trợ"});
            this.cmbLoaiThu.Location = new System.Drawing.Point(339, 274);
            this.cmbLoaiThu.Name = "cmbLoaiThu";
            this.cmbLoaiThu.Size = new System.Drawing.Size(183, 39);
            this.cmbLoaiThu.TabIndex = 7;
            this.cmbLoaiThu.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiThu_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(102, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 34);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mô tả";
            // 
            // txtMota
            // 
            this.txtMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMota.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMota.Location = new System.Drawing.Point(339, 353);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(274, 104);
            this.txtMota.TabIndex = 8;
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(212, 504);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(302, 49);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // ThemSuaKhoanThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 580);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.cmbLoaiThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBatDau);
            this.Controls.Add(this.lblDinhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDinhMuc);
            this.Controls.Add(this.txtTenKhoanThu);
            this.Name = "ThemSuaKhoanThu";
            this.Text = "Thêm Khoản Thu";
            this.Load += new System.EventHandler(this.ThuChi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenKhoanThu;
        private System.Windows.Forms.TextBox txtDinhMuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDinhMuc;
        private System.Windows.Forms.DateTimePicker dtpBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLoaiThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Button btnThem;
    }
}
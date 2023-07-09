namespace TodoApp
{
    partial class ThemSuaSuKien
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
            this.dtpNgayToChuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSuKien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.lblLinkAnh = new System.Windows.Forms.Label();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.pbAnhSuKien = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSuKien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(235, 636);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(302, 49);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(141, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 34);
            this.label3.TabIndex = 38;
            this.label3.Text = "Ngày Tổ Chức";
            // 
            // dtpNgayToChuc
            // 
            this.dtpNgayToChuc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayToChuc.CustomFormat = "  dd/ MM/ yyyy";
            this.dtpNgayToChuc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayToChuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayToChuc.Location = new System.Drawing.Point(412, 139);
            this.dtpNgayToChuc.Name = "dtpNgayToChuc";
            this.dtpNgayToChuc.Size = new System.Drawing.Size(201, 28);
            this.dtpNgayToChuc.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(140, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 34);
            this.label2.TabIndex = 46;
            this.label2.Text = "Ảnh Sự Kiện";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(141, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 45;
            this.label1.Text = "Tên Sự Kiện";
            // 
            // txtTenSuKien
            // 
            this.txtTenSuKien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenSuKien.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenSuKien.Location = new System.Drawing.Point(412, 71);
            this.txtTenSuKien.Name = "txtTenSuKien";
            this.txtTenSuKien.Size = new System.Drawing.Size(274, 37);
            this.txtTenSuKien.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(140, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 34);
            this.label5.TabIndex = 48;
            this.label5.Text = "Địa Điểm";
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiaDiem.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiaDiem.Location = new System.Drawing.Point(411, 206);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(274, 37);
            this.txtDiaDiem.TabIndex = 47;
            // 
            // lblLinkAnh
            // 
            this.lblLinkAnh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLinkAnh.AutoSize = true;
            this.lblLinkAnh.Location = new System.Drawing.Point(409, 560);
            this.lblLinkAnh.Name = "lblLinkAnh";
            this.lblLinkAnh.Size = new System.Drawing.Size(52, 16);
            this.lblLinkAnh.TabIndex = 50;
            this.lblLinkAnh.Text = "link ảnh";
            this.lblLinkAnh.Visible = false;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonFile.BackColor = System.Drawing.Color.White;
            this.btnChonFile.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChonFile.ForeColor = System.Drawing.Color.Black;
            this.btnChonFile.Image = global::TodoApp.Properties.Resources.icons8_dropdown_32;
            this.btnChonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonFile.Location = new System.Drawing.Point(602, 292);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(126, 32);
            this.btnChonFile.TabIndex = 51;
            this.btnChonFile.Text = "Chọn Ảnh";
            this.btnChonFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonFile.UseVisualStyleBackColor = false;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // pbAnhSuKien
            // 
            this.pbAnhSuKien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbAnhSuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbAnhSuKien.Location = new System.Drawing.Point(411, 350);
            this.pbAnhSuKien.Name = "pbAnhSuKien";
            this.pbAnhSuKien.Size = new System.Drawing.Size(317, 188);
            this.pbAnhSuKien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnhSuKien.TabIndex = 49;
            this.pbAnhSuKien.TabStop = false;
            this.pbAnhSuKien.Click += new System.EventHandler(this.pbAnhSuKien_Click);
            // 
            // ThemSuaSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 732);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.lblLinkAnh);
            this.Controls.Add(this.pbAnhSuKien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTenSuKien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpNgayToChuc);
            this.Name = "ThemSuaSuKien";
            this.Text = "Thêm Sửa Sự Kiện";
            this.Load += new System.EventHandler(this.ThemSuaSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnhSuKien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgayToChuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenSuKien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.PictureBox pbAnhSuKien;
        private System.Windows.Forms.Label lblLinkAnh;
        private System.Windows.Forms.Button btnChonFile;
    }
}
namespace TodoApp.customControls
{
    partial class CustomTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblState = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblDes = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.customButton2 = new TodoApp.Controls.CustomButton();
            this.customButton1 = new TodoApp.Controls.CustomButton();
            this.lblGroup = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.White;
            this.lblState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Black;
            this.lblState.Location = new System.Drawing.Point(31, 162);
            this.lblState.Name = "lblState";
            this.lblState.Padding = new System.Windows.Forms.Padding(5);
            this.lblState.Size = new System.Drawing.Size(66, 35);
            this.lblState.TabIndex = 6;
            this.lblState.Text = "State";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblEnd.Location = new System.Drawing.Point(89, 215);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(75, 23);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Text = "EndDate";
            // 
            // lblDes
            // 
            this.lblDes.AutoSize = true;
            this.lblDes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDes.Location = new System.Drawing.Point(40, 73);
            this.lblDes.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblDes.Name = "lblDes";
            this.lblDes.Size = new System.Drawing.Size(80, 20);
            this.lblDes.TabIndex = 4;
            this.lblDes.Text = "Desciption";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTaskName.Location = new System.Drawing.Point(38, 31);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(126, 27);
            this.lblTaskName.TabIndex = 3;
            this.lblTaskName.Text = "TaskName";
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 5;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(173, 267);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(78, 40);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "Xóa";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 5;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("#9Slide03 Arima Madurai Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(36, 267);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(84, 40);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Sửa";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGroup.Location = new System.Drawing.Point(39, 123);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(68, 28);
            this.lblGroup.TabIndex = 7;
            this.lblGroup.Text = "Group";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TodoApp.Properties.Resources.icons8_day_off_241;
            this.pictureBox1.Location = new System.Drawing.Point(44, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CustomTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.lblDes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(0, 15, 20, 0);
            this.Name = "CustomTask";
            this.Size = new System.Drawing.Size(272, 321);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Controls.CustomButton customButton1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblDes;
        private System.Windows.Forms.Label lblTaskName;
        private Controls.CustomButton customButton2;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

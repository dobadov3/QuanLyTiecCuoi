namespace QLTCBasic
{
    partial class FormLap
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
            this.btnLapphieudattiec = new System.Windows.Forms.Button();
            this.btnXuathoadon = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLapphieudattiec
            // 
            this.btnLapphieudattiec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLapphieudattiec.ForeColor = System.Drawing.Color.Crimson;
            this.btnLapphieudattiec.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnLapphieudattiec.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnLapphieudattiec.Location = new System.Drawing.Point(513, 238);
            this.btnLapphieudattiec.Name = "btnLapphieudattiec";
            this.btnLapphieudattiec.Size = new System.Drawing.Size(199, 94);
            this.btnLapphieudattiec.TabIndex = 27;
            this.btnLapphieudattiec.Text = "Phiếu đặt tiệc";
            this.btnLapphieudattiec.UseVisualStyleBackColor = true;
            this.btnLapphieudattiec.Click += new System.EventHandler(this.btnLapphieudattiec_Click);
            // 
            // btnXuathoadon
            // 
            this.btnXuathoadon.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXuathoadon.ForeColor = System.Drawing.Color.Crimson;
            this.btnXuathoadon.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnXuathoadon.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXuathoadon.Location = new System.Drawing.Point(269, 238);
            this.btnXuathoadon.Name = "btnXuathoadon";
            this.btnXuathoadon.Size = new System.Drawing.Size(199, 94);
            this.btnXuathoadon.TabIndex = 26;
            this.btnXuathoadon.Text = "Hóa đơn";
            this.btnXuathoadon.UseVisualStyleBackColor = true;
            this.btnXuathoadon.Click += new System.EventHandler(this.btnXuathoadon_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(822, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(135, 37);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTCBasic.Properties.Resources._33;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 572);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // FormLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 563);
            this.Controls.Add(this.btnLapphieudattiec);
            this.Controls.Add(this.btnXuathoadon);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "FormLap";
            this.Text = "Dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLapphieudattiec;
        private System.Windows.Forms.Button btnXuathoadon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
namespace QLTCBasic
{
    partial class Formbaocao
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
            this.btnBCNoibo = new System.Windows.Forms.Button();
            this.btnBCTaichinh = new System.Windows.Forms.Button();
            this.btnBCBaotri = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBCNoibo
            // 
            this.btnBCNoibo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBCNoibo.ForeColor = System.Drawing.Color.Crimson;
            this.btnBCNoibo.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBCNoibo.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBCNoibo.Location = new System.Drawing.Point(395, 233);
            this.btnBCNoibo.Name = "btnBCNoibo";
            this.btnBCNoibo.Size = new System.Drawing.Size(199, 94);
            this.btnBCNoibo.TabIndex = 28;
            this.btnBCNoibo.Text = "Báo cáo thông tin nhập xuất kho";
            this.btnBCNoibo.UseVisualStyleBackColor = true;
            this.btnBCNoibo.Click += new System.EventHandler(this.btnBCNoibo_Click);
            // 
            // btnBCTaichinh
            // 
            this.btnBCTaichinh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBCTaichinh.ForeColor = System.Drawing.Color.Crimson;
            this.btnBCTaichinh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBCTaichinh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBCTaichinh.Location = new System.Drawing.Point(639, 233);
            this.btnBCTaichinh.Name = "btnBCTaichinh";
            this.btnBCTaichinh.Size = new System.Drawing.Size(199, 94);
            this.btnBCTaichinh.TabIndex = 27;
            this.btnBCTaichinh.Text = "Báo cáo tài chính";
            this.btnBCTaichinh.UseVisualStyleBackColor = true;
            this.btnBCTaichinh.Click += new System.EventHandler(this.btnBCTaichinh_Click);
            // 
            // btnBCBaotri
            // 
            this.btnBCBaotri.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBCBaotri.ForeColor = System.Drawing.Color.Crimson;
            this.btnBCBaotri.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBCBaotri.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBCBaotri.Location = new System.Drawing.Point(148, 233);
            this.btnBCBaotri.Name = "btnBCBaotri";
            this.btnBCBaotri.Size = new System.Drawing.Size(199, 94);
            this.btnBCBaotri.TabIndex = 26;
            this.btnBCBaotri.Text = "Báo cáo thông tin bảo trì";
            this.btnBCBaotri.UseVisualStyleBackColor = true;
            this.btnBCBaotri.Click += new System.EventHandler(this.btnBCBaotri_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(823, 12);
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
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 572);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Formbaocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 561);
            this.Controls.Add(this.btnBCNoibo);
            this.Controls.Add(this.btnBCTaichinh);
            this.Controls.Add(this.btnBCBaotri);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Formbaocao";
            this.Text = "Báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBCTaichinh;
        private System.Windows.Forms.Button btnBCBaotri;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBCNoibo;
    }
}
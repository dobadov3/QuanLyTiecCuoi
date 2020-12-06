namespace QLTCBasic
{
    partial class Formsanh
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
            this.txtMasanh = new System.Windows.Forms.TextBox();
            this.cmbLoaisanh = new System.Windows.Forms.ComboBox();
            this.txtTensanh = new System.Windows.Forms.TextBox();
            this.dgvSanh = new System.Windows.Forms.DataGridView();
            this.btnSuasanh = new System.Windows.Forms.Button();
            this.btnThemsanh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnXoasanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMasanh
            // 
            this.txtMasanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMasanh.Location = new System.Drawing.Point(149, 37);
            this.txtMasanh.Name = "txtMasanh";
            this.txtMasanh.Size = new System.Drawing.Size(218, 23);
            this.txtMasanh.TabIndex = 52;
            // 
            // cmbLoaisanh
            // 
            this.cmbLoaisanh.FormattingEnabled = true;
            this.cmbLoaisanh.Location = new System.Drawing.Point(149, 66);
            this.cmbLoaisanh.Name = "cmbLoaisanh";
            this.cmbLoaisanh.Size = new System.Drawing.Size(218, 21);
            this.cmbLoaisanh.TabIndex = 46;
            // 
            // txtTensanh
            // 
            this.txtTensanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTensanh.Location = new System.Drawing.Point(149, 8);
            this.txtTensanh.Name = "txtTensanh";
            this.txtTensanh.Size = new System.Drawing.Size(218, 23);
            this.txtTensanh.TabIndex = 44;
            // 
            // dgvSanh
            // 
            this.dgvSanh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanh.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanh.Location = new System.Drawing.Point(12, 101);
            this.dgvSanh.Name = "dgvSanh";
            this.dgvSanh.Size = new System.Drawing.Size(827, 443);
            this.dgvSanh.TabIndex = 37;
            // 
            // btnSuasanh
            // 
            this.btnSuasanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuasanh.ForeColor = System.Drawing.Color.Crimson;
            this.btnSuasanh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnSuasanh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSuasanh.Location = new System.Drawing.Point(472, 55);
            this.btnSuasanh.Name = "btnSuasanh";
            this.btnSuasanh.Size = new System.Drawing.Size(128, 40);
            this.btnSuasanh.TabIndex = 56;
            this.btnSuasanh.Text = "Sửa sảnh";
            this.btnSuasanh.UseVisualStyleBackColor = true;
            this.btnSuasanh.Click += new System.EventHandler(this.btnEditsanh_Click);
            // 
            // btnThemsanh
            // 
            this.btnThemsanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThemsanh.ForeColor = System.Drawing.Color.Crimson;
            this.btnThemsanh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnThemsanh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnThemsanh.Location = new System.Drawing.Point(396, 8);
            this.btnThemsanh.Name = "btnThemsanh";
            this.btnThemsanh.Size = new System.Drawing.Size(128, 38);
            this.btnThemsanh.TabIndex = 55;
            this.btnThemsanh.Text = "Thêm sảnh";
            this.btnThemsanh.UseVisualStyleBackColor = true;
            this.btnThemsanh.Click += new System.EventHandler(this.btnAddsanh_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Image = global::QLTCBasic.Properties.Resources._33;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(10, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 22);
            this.label8.TabIndex = 51;
            this.label8.Text = "Mã sảnh";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Image = global::QLTCBasic.Properties.Resources._33;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Loại sảnh";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Image = global::QLTCBasic.Properties.Resources._33;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên sảnh";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(694, 8);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(145, 37);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTCBasic.Properties.Resources._33;
            this.pictureBox1.Location = new System.Drawing.Point(0, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 565);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoasanh
            // 
            this.btnXoasanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoasanh.ForeColor = System.Drawing.Color.Crimson;
            this.btnXoasanh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnXoasanh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXoasanh.Location = new System.Drawing.Point(543, 8);
            this.btnXoasanh.Name = "btnXoasanh";
            this.btnXoasanh.Size = new System.Drawing.Size(128, 38);
            this.btnXoasanh.TabIndex = 57;
            this.btnXoasanh.Text = "Xóa sảnh";
            this.btnXoasanh.UseVisualStyleBackColor = true;
            this.btnXoasanh.Click += new System.EventHandler(this.btnDelsanh_Click);
            // 
            // Formsanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 556);
            this.Controls.Add(this.btnXoasanh);
            this.Controls.Add(this.btnSuasanh);
            this.Controls.Add(this.btnThemsanh);
            this.Controls.Add(this.txtMasanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbLoaisanh);
            this.Controls.Add(this.txtTensanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvSanh);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Formsanh";
            this.Text = "Quản lý sảnh";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMasanh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbLoaisanh;
        private System.Windows.Forms.TextBox txtTensanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvSanh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnThemsanh;
        private System.Windows.Forms.Button btnSuasanh;
        private System.Windows.Forms.Button btnXoasanh;
    }
}
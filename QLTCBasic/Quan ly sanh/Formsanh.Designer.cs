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
            this.txtMasanh.Location = new System.Drawing.Point(199, 46);
            this.txtMasanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasanh.Name = "txtMasanh";
            this.txtMasanh.Size = new System.Drawing.Size(289, 27);
            this.txtMasanh.TabIndex = 52;
            // 
            // cmbLoaisanh
            // 
            this.cmbLoaisanh.FormattingEnabled = true;
            this.cmbLoaisanh.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbLoaisanh.Location = new System.Drawing.Point(199, 81);
            this.cmbLoaisanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLoaisanh.Name = "cmbLoaisanh";
            this.cmbLoaisanh.Size = new System.Drawing.Size(289, 24);
            this.cmbLoaisanh.TabIndex = 46;
            // 
            // txtTensanh
            // 
            this.txtTensanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTensanh.Location = new System.Drawing.Point(199, 10);
            this.txtTensanh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTensanh.Name = "txtTensanh";
            this.txtTensanh.Size = new System.Drawing.Size(289, 27);
            this.txtTensanh.TabIndex = 44;
            // 
            // dgvSanh
            // 
            this.dgvSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanh.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSanh.Location = new System.Drawing.Point(16, 124);
            this.dgvSanh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanh.Name = "dgvSanh";
            this.dgvSanh.RowHeadersWidth = 51;
            this.dgvSanh.Size = new System.Drawing.Size(1103, 545);
            this.dgvSanh.TabIndex = 37;
            // 
            // btnSuasanh
            // 
            this.btnSuasanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuasanh.ForeColor = System.Drawing.Color.Crimson;
            this.btnSuasanh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnSuasanh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSuasanh.Location = new System.Drawing.Point(629, 68);
            this.btnSuasanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuasanh.Name = "btnSuasanh";
            this.btnSuasanh.Size = new System.Drawing.Size(171, 49);
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
            this.btnThemsanh.Location = new System.Drawing.Point(528, 10);
            this.btnThemsanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemsanh.Name = "btnThemsanh";
            this.btnThemsanh.Size = new System.Drawing.Size(171, 47);
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
            this.label8.Location = new System.Drawing.Point(13, 46);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 27);
            this.label8.TabIndex = 51;
            this.label8.Text = "Mã sảnh";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Image = global::QLTCBasic.Properties.Resources._33;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(13, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "Loại sảnh";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Image = global::QLTCBasic.Properties.Resources._33;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tên sảnh";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(925, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(193, 46);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTCBasic.Properties.Resources._33;
            this.pictureBox1.Location = new System.Drawing.Point(0, -9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1300, 695);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // btnXoasanh
            // 
            this.btnXoasanh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoasanh.ForeColor = System.Drawing.Color.Crimson;
            this.btnXoasanh.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnXoasanh.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXoasanh.Location = new System.Drawing.Point(724, 10);
            this.btnXoasanh.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoasanh.Name = "btnXoasanh";
            this.btnXoasanh.Size = new System.Drawing.Size(171, 47);
            this.btnXoasanh.TabIndex = 57;
            this.btnXoasanh.Text = "Xóa sảnh";
            this.btnXoasanh.UseVisualStyleBackColor = true;
            this.btnXoasanh.Click += new System.EventHandler(this.btnDelsanh_Click);
            // 
            // Formsanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 684);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Formsanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
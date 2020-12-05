namespace QLTCBasic
{
    partial class Formkhachhang
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
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTypekhach = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbStatuskhach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenkhach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDelkhach = new System.Windows.Forms.Button();
            this.btnEditkhach = new System.Windows.Forms.Button();
            this.btnAddkhach = new System.Windows.Forms.Button();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDiachi.Location = new System.Drawing.Point(197, 133);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(289, 27);
            this.txtDiachi.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Image = global::QLTCBasic.Properties.Resources._33;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(15, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 27);
            this.label8.TabIndex = 34;
            this.label8.Text = "Địa chỉ";
            // 
            // cmbTypekhach
            // 
            this.cmbTypekhach.FormattingEnabled = true;
            this.cmbTypekhach.Items.AddRange(new object[] {
            "Thường",
            "V.I.P"});
            this.cmbTypekhach.Location = new System.Drawing.Point(732, 59);
            this.cmbTypekhach.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTypekhach.Name = "cmbTypekhach";
            this.cmbTypekhach.Size = new System.Drawing.Size(289, 24);
            this.cmbTypekhach.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Image = global::QLTCBasic.Properties.Resources._33;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(549, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 27);
            this.label6.TabIndex = 30;
            this.label6.Text = "Loại thành viên";
            // 
            // cmbStatuskhach
            // 
            this.cmbStatuskhach.FormattingEnabled = true;
            this.cmbStatuskhach.Items.AddRange(new object[] {
            "Còn hiệu lực",
            "Vô hiệu lực"});
            this.cmbStatuskhach.Location = new System.Drawing.Point(732, 26);
            this.cmbStatuskhach.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStatuskhach.Name = "cmbStatuskhach";
            this.cmbStatuskhach.Size = new System.Drawing.Size(289, 24);
            this.cmbStatuskhach.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Image = global::QLTCBasic.Properties.Resources._33;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.Location = new System.Drawing.Point(15, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã khách hàng";
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaysinh.Location = new System.Drawing.Point(197, 62);
            this.txtNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(289, 27);
            this.txtNgaysinh.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Image = global::QLTCBasic.Properties.Resources._33;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(15, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 27);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày sinh";
            // 
            // txtMakhach
            // 
            this.txtMakhach.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMakhach.Location = new System.Drawing.Point(197, 97);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(289, 27);
            this.txtMakhach.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Image = global::QLTCBasic.Properties.Resources._33;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label3.Location = new System.Drawing.Point(549, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 27);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tình trạng hồ sơ";
            // 
            // txtTenkhach
            // 
            this.txtTenkhach.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenkhach.Location = new System.Drawing.Point(197, 26);
            this.txtTenkhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenkhach.Name = "txtTenkhach";
            this.txtTenkhach.Size = new System.Drawing.Size(289, 27);
            this.txtTenkhach.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Image = global::QLTCBasic.Properties.Resources._33;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ tên";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(1067, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(215, 46);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhach.Location = new System.Drawing.Point(13, 204);
            this.dgvKhach.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.Size = new System.Drawing.Size(1268, 468);
            this.dgvKhach.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTCBasic.Properties.Resources._33;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1299, 704);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnDelkhach
            // 
            this.btnDelkhach.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDelkhach.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelkhach.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnDelkhach.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDelkhach.Location = new System.Drawing.Point(1077, 97);
            this.btnDelkhach.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelkhach.Name = "btnDelkhach";
            this.btnDelkhach.Size = new System.Drawing.Size(204, 100);
            this.btnDelkhach.TabIndex = 60;
            this.btnDelkhach.Text = "Xóa hồ sơ";
            this.btnDelkhach.UseVisualStyleBackColor = true;
            this.btnDelkhach.Click += new System.EventHandler(this.btnDelkhach_Click);
            // 
            // btnEditkhach
            // 
            this.btnEditkhach.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEditkhach.ForeColor = System.Drawing.Color.Crimson;
            this.btnEditkhach.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnEditkhach.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnEditkhach.Location = new System.Drawing.Point(813, 97);
            this.btnEditkhach.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditkhach.Name = "btnEditkhach";
            this.btnEditkhach.Size = new System.Drawing.Size(204, 100);
            this.btnEditkhach.TabIndex = 59;
            this.btnEditkhach.Text = "Sửa hồ sơ";
            this.btnEditkhach.UseVisualStyleBackColor = true;
            this.btnEditkhach.Click += new System.EventHandler(this.btnEditkhach_Click);
            // 
            // btnAddkhach
            // 
            this.btnAddkhach.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddkhach.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddkhach.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnAddkhach.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddkhach.Location = new System.Drawing.Point(549, 97);
            this.btnAddkhach.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddkhach.Name = "btnAddkhach";
            this.btnAddkhach.Size = new System.Drawing.Size(204, 100);
            this.btnAddkhach.TabIndex = 58;
            this.btnAddkhach.Text = "Thêm hồ sơ";
            this.btnAddkhach.UseVisualStyleBackColor = true;
            this.btnAddkhach.Click += new System.EventHandler(this.btnAddkhach_Click);
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCMND.Location = new System.Drawing.Point(197, 169);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(289, 27);
            this.txtCMND.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Image = global::QLTCBasic.Properties.Resources._33;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(15, 166);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 27);
            this.label1.TabIndex = 61;
            this.label1.Text = "CMND";
            // 
            // Formkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 682);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelkhach);
            this.Controls.Add(this.btnEditkhach);
            this.Controls.Add(this.btnAddkhach);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbTypekhach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbStatuskhach);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNgaysinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenkhach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvKhach);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Formkhachhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTypekhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbStatuskhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenkhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelkhach;
        private System.Windows.Forms.Button btnEditkhach;
        private System.Windows.Forms.Button btnAddkhach;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label1;
    }
}
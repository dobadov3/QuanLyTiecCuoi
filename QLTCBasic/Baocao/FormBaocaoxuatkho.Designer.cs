namespace QLTCBasic
{
    partial class FormBaocaoxuatkho
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
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoabaocao = new System.Windows.Forms.Button();
            this.btnSuabaocao = new System.Windows.Forms.Button();
            this.btnThembaocao = new System.Windows.Forms.Button();
            this.txtTennguoibaocao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMabaocaothuchi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBaocaoxuatkho = new System.Windows.Forms.DataGridView();
            this.txtTongchiphi = new System.Windows.Forms.TextBox();
            this.txtNgayxuatkho = new System.Windows.Forms.TextBox();
            this.txtMabaocao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgaybaocao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocaoxuatkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Crimson;
            this.btnTimkiem.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTimkiem.Location = new System.Drawing.Point(1120, 101);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(204, 46);
            this.btnTimkiem.TabIndex = 150;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoabaocao
            // 
            this.btnXoabaocao.Enabled = false;
            this.btnXoabaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoabaocao.ForeColor = System.Drawing.Color.Crimson;
            this.btnXoabaocao.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnXoabaocao.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnXoabaocao.Location = new System.Drawing.Point(908, 101);
            this.btnXoabaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoabaocao.Name = "btnXoabaocao";
            this.btnXoabaocao.Size = new System.Drawing.Size(116, 46);
            this.btnXoabaocao.TabIndex = 149;
            this.btnXoabaocao.Text = "Xóa";
            this.btnXoabaocao.UseVisualStyleBackColor = true;
            this.btnXoabaocao.Click += new System.EventHandler(this.btnXoabaocao_Click);
            // 
            // btnSuabaocao
            // 
            this.btnSuabaocao.Enabled = false;
            this.btnSuabaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSuabaocao.ForeColor = System.Drawing.Color.Crimson;
            this.btnSuabaocao.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnSuabaocao.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSuabaocao.Location = new System.Drawing.Point(733, 101);
            this.btnSuabaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuabaocao.Name = "btnSuabaocao";
            this.btnSuabaocao.Size = new System.Drawing.Size(127, 46);
            this.btnSuabaocao.TabIndex = 148;
            this.btnSuabaocao.Text = "Sửa";
            this.btnSuabaocao.UseVisualStyleBackColor = true;
            this.btnSuabaocao.Click += new System.EventHandler(this.btnSuabaocao_Click);
            // 
            // btnThembaocao
            // 
            this.btnThembaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThembaocao.ForeColor = System.Drawing.Color.Crimson;
            this.btnThembaocao.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnThembaocao.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnThembaocao.Location = new System.Drawing.Point(555, 101);
            this.btnThembaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThembaocao.Name = "btnThembaocao";
            this.btnThembaocao.Size = new System.Drawing.Size(132, 46);
            this.btnThembaocao.TabIndex = 147;
            this.btnThembaocao.Text = "Thêm";
            this.btnThembaocao.UseVisualStyleBackColor = true;
            this.btnThembaocao.Click += new System.EventHandler(this.btnThembaocao_Click);
            // 
            // txtTennguoibaocao
            // 
            this.txtTennguoibaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTennguoibaocao.Location = new System.Drawing.Point(220, 85);
            this.txtTennguoibaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTennguoibaocao.Name = "txtTennguoibaocao";
            this.txtTennguoibaocao.Size = new System.Drawing.Size(268, 27);
            this.txtTennguoibaocao.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Image = global::QLTCBasic.Properties.Resources._33;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 27);
            this.label2.TabIndex = 145;
            this.label2.Text = "Tên người báo cáo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMabaocaothuchi
            // 
            this.txtMabaocaothuchi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMabaocaothuchi.Location = new System.Drawing.Point(220, 121);
            this.txtMabaocaothuchi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMabaocaothuchi.Name = "txtMabaocaothuchi";
            this.txtMabaocaothuchi.Size = new System.Drawing.Size(268, 27);
            this.txtMabaocaothuchi.TabIndex = 144;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Image = global::QLTCBasic.Properties.Resources._33;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(16, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 27);
            this.label1.TabIndex = 143;
            this.label1.Text = "Mã báo cáo thu chi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBaocaoxuatkho
            // 
            this.dgvBaocaoxuatkho.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBaocaoxuatkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaocaoxuatkho.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvBaocaoxuatkho.Location = new System.Drawing.Point(15, 156);
            this.dgvBaocaoxuatkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBaocaoxuatkho.Name = "dgvBaocaoxuatkho";
            this.dgvBaocaoxuatkho.RowHeadersWidth = 51;
            this.dgvBaocaoxuatkho.Size = new System.Drawing.Size(1309, 535);
            this.dgvBaocaoxuatkho.TabIndex = 142;
            // 
            // txtTongchiphi
            // 
            this.txtTongchiphi.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongchiphi.Location = new System.Drawing.Point(733, 47);
            this.txtTongchiphi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongchiphi.Name = "txtTongchiphi";
            this.txtTongchiphi.Size = new System.Drawing.Size(289, 27);
            this.txtTongchiphi.TabIndex = 140;
            // 
            // txtNgayxuatkho
            // 
            this.txtNgayxuatkho.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgayxuatkho.Location = new System.Drawing.Point(733, 7);
            this.txtNgayxuatkho.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgayxuatkho.Name = "txtNgayxuatkho";
            this.txtNgayxuatkho.Size = new System.Drawing.Size(289, 27);
            this.txtNgayxuatkho.TabIndex = 139;
            // 
            // txtMabaocao
            // 
            this.txtMabaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMabaocao.Location = new System.Drawing.Point(220, 10);
            this.txtMabaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMabaocao.Name = "txtMabaocao";
            this.txtMabaocao.Size = new System.Drawing.Size(268, 27);
            this.txtMabaocao.TabIndex = 138;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Image = global::QLTCBasic.Properties.Resources._33;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label8.Location = new System.Drawing.Point(16, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 27);
            this.label8.TabIndex = 137;
            this.label8.Text = "Mã báo cáo xuất kho";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Image = global::QLTCBasic.Properties.Resources._33;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label7.Location = new System.Drawing.Point(551, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 27);
            this.label7.TabIndex = 136;
            this.label7.Text = "Tổng chi phí xuất";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Image = global::QLTCBasic.Properties.Resources._33;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label6.Location = new System.Drawing.Point(551, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 27);
            this.label6.TabIndex = 135;
            this.label6.Text = "Ngày xuất kho";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNgaybaocao
            // 
            this.txtNgaybaocao.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNgaybaocao.Location = new System.Drawing.Point(220, 48);
            this.txtNgaybaocao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgaybaocao.Name = "txtNgaybaocao";
            this.txtNgaybaocao.Size = new System.Drawing.Size(268, 27);
            this.txtNgaybaocao.TabIndex = 134;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Image = global::QLTCBasic.Properties.Resources._33;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(16, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 27);
            this.label4.TabIndex = 133;
            this.label4.Text = "Ngày báo cáo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.Crimson;
            this.btnBack.Image = global::QLTCBasic.Properties.Resources._33;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnBack.Location = new System.Drawing.Point(1120, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(204, 46);
            this.btnBack.TabIndex = 131;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLTCBasic.Properties.Resources._33;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1345, 718);
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // FormBaocaoxuatkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 706);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoabaocao);
            this.Controls.Add(this.btnSuabaocao);
            this.Controls.Add(this.btnThembaocao);
            this.Controls.Add(this.txtTennguoibaocao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMabaocaothuchi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBaocaoxuatkho);
            this.Controls.Add(this.txtTongchiphi);
            this.Controls.Add(this.txtNgayxuatkho);
            this.Controls.Add(this.txtMabaocao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgaybaocao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormBaocaoxuatkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo xuất kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocaoxuatkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoabaocao;
        private System.Windows.Forms.Button btnSuabaocao;
        private System.Windows.Forms.Button btnThembaocao;
        private System.Windows.Forms.TextBox txtTennguoibaocao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMabaocaothuchi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBaocaoxuatkho;
        private System.Windows.Forms.TextBox txtTongchiphi;
        private System.Windows.Forms.TextBox txtNgayxuatkho;
        private System.Windows.Forms.TextBox txtMabaocao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNgaybaocao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
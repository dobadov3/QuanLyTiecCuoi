using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTCBasic
{
    public partial class FormBaocaonhapkho : Form
    {
        public FormBaocaonhapkho()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnThembaocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo của bạn đã được gửi thành công!");
        }

        private void btnSuabaocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo của bạn đã được sửa thành công!");
        }

        private void btnXoabaocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo của bạn đã được xóa thành công!");
        }
    }
}

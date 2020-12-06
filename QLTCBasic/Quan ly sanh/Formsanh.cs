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
    public partial class Formsanh : Form
    {
        public Formsanh()
        {
            InitializeComponent();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddsanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thành công!");
        }

        private void btnEditsanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thành công!");
        }

        private void btnDelsanh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công!");
        }
    }
}

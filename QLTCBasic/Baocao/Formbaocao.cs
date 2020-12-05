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
    public partial class Formbaocao : Form
    {
        public Formbaocao()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBCBaotri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var baocaobaotri = new FormBaocaobaotri();
            baocaobaotri.ShowDialog();
            this.Show();
        }

        private void btnBCTaichinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaotaichinh = new FormBaocaotaichinh();
            formBaocaotaichinh.ShowDialog();
            this.Show();
        }

        private void btnBCNoibo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaokho = new FormBaocaokho();
            formBaocaokho.ShowDialog();
            this.Show();
        }
    }
}

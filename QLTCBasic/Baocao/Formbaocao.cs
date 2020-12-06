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
            var main = new Main();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btnBCBaotri_Click(object sender, EventArgs e)
        {
            this.Hide();
            var baocaobaotri = new FormBaocaobaotri();
            baocaobaotri.Closed += (s, args) => this.Close();
            baocaobaotri.Show();
        }

        private void btnBCTaichinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaotaichinh = new FormBaocaotaichinh();
            formBaocaotaichinh.Closed += (s, args) => this.Close();
            formBaocaotaichinh.Show();
        }

        private void btnBCNoibo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaokho = new FormBaocaokho();
            formBaocaokho.Closed += (s, args) => this.Close();
            formBaocaokho.Show();
        }
    }
}

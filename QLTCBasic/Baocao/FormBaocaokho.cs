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
    public partial class FormBaocaokho : Form
    {
        public FormBaocaokho()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaonhapkho = new FormBaocaonhapkho();
            formBaocaonhapkho.Closed += (s, args) => this.Close();
            formBaocaonhapkho.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBaocaoxuatkho = new FormBaocaoxuatkho();
            formBaocaoxuatkho.Closed += (s, args) => this.Close();
            formBaocaoxuatkho.Show();
        }
    }
}

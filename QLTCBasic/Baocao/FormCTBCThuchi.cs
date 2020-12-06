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
    public partial class FormCTBCThuchi : Form
    {
        public FormCTBCThuchi()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Hide();
            var main = new FormBaocaothuchingay();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

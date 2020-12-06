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
    public partial class FormHoadon : Form
    {
        public FormHoadon()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    


        private void btnTracuu_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnThongtinTiec_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var tieccuoi = new FormPhieudattiec();
            tieccuoi.ShowDialog();
            this.Show();
        }
    }
}

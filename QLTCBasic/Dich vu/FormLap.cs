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
    public partial class FormLap : Form
    {
        public FormLap()
        {
            InitializeComponent();
        }

        private void btnLapphieudattiec_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPhieudattiec = new FormPhieudattiec();
            formPhieudattiec.ShowDialog();
            this.Show();
        }

        private void btnXuathoadon_Click(object sender, EventArgs e)
        {
            this.Hide();
            var fHoaDon = new FormHoadon();
            fHoaDon.ShowDialog();
            this.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

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
    public partial class FormPhieudattiec : Form
    {
        public FormPhieudattiec()
        {
            InitializeComponent();
        }



        private void btnLapdon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thành công!");
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new FormLap();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btnSuadon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoadon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công!");
        }

        private void btnCTDV_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ctdichvu = new FormChitietDV();
            ctdichvu.Closed += (s, args) => this.Close();
            ctdichvu.Show();
        }

        private void btnCTMA_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ctmonan = new FormChitietMonan();
            ctmonan.Closed += (s, args) => this.Close();
            ctmonan.Show();
        }

        private void btnCTBAN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ctban = new FormChitietBan();
            ctban.Closed += (s, args) => this.Close();
            ctban.Show();
        }
    }
}

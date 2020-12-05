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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnSanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var sanh = new Formsanh();
            sanh.ShowDialog();
            this.Show();
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var tracuu = new Formtracuu();
            tracuu.ShowDialog();
            this.Show();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formkhachhang khach = new Formkhachhang();
            khach.ShowDialog();
            this.Show();
        }

        private void btnTaichinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lap = new FormLap();
            lap.ShowDialog();
            this.Show();
        }

        private void btnHopdong_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hopdong = new FormHopdong();
            hopdong.ShowDialog();
            this.Show();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var baocao = new Formbaocao();
            baocao.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công");
            this.Hide();
        }
    }
}

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
            sanh.Closed += (s, args) => this.Close();
            sanh.Show();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            this.Hide();
            var khach = new Formkhachhang();
            khach.Closed += (s, args) => this.Close();
            khach.Show();
        }

        private void btnTaichinh_Click(object sender, EventArgs e)
        {
            this.Hide();
            var lap = new FormLap();
            lap.Closed += (s, args) => this.Close();
            lap.Show();
        }

        private void btnHopdong_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hopdong = new FormHopdong();
            hopdong.Closed += (s, args) => this.Close();
            hopdong.Show();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            this.Hide();
            var baocao = new Formbaocao();
            baocao.Closed += (s, args) => this.Close();
            baocao.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng xuất thành công!");
            this.Hide();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }
    }
}

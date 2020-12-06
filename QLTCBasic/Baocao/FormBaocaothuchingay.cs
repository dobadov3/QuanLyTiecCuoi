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
    public partial class FormBaocaothuchingay : Form
    {
        public FormBaocaothuchingay()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Formbaocao();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ctbcthuchi = new FormCTBCThuchi();
            ctbcthuchi.Closed += (s, args) => this.Close();
            ctbcthuchi.Show();
        }

        private void btnGuibaocao_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo của bạn đã được gửi thành công!");
        }
    }
}

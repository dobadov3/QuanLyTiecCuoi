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
    public partial class FormBaocaobaotri : Form
    {
        public FormBaocaobaotri()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var main = new Formbaocao();
            main.Closed += (s, args) => this.Close();
            main.Show();
        }

        private void btnGuibaocao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo của bạn đã được gửi thành công!");
        }

        private void btnTracuu_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}

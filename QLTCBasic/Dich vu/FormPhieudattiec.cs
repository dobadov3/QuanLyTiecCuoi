﻿using System;
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
        }

        private void btnSuadon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoadon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công!");
        }
    }
}

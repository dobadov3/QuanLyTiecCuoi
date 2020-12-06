using QLTCBasic.BUS;
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
    public partial class Formsanh : Form
    {
        public Formsanh()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            SanhBUS.Instance.LoadSanh(dgvSanh);
            AddBinding();
        }
        void AddBinding()
        {
            txtMasanh.DataBindings.Clear();
            txtTensanh.DataBindings.Clear();
            cmbLoaisanh.DataBindings.Clear();

            txtMasanh.DataBindings.Add("Text", dgvSanh.DataSource, "MaSanh");
            txtTensanh.DataBindings.Add("Text", dgvSanh.DataSource, "TenSanh");
            cmbLoaisanh.DataBindings.Add("Text", dgvSanh.DataSource, "LoaiSanh");
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddsanh_Click(object sender, EventArgs e)
        {
            SanhBUS.Instance.Insert(txtMasanh, txtTensanh, cmbLoaisanh);
            LoadData();
        }

        private void btnEditsanh_Click(object sender, EventArgs e)
        {
            SanhBUS.Instance.Update(txtMasanh, txtTensanh, cmbLoaisanh);
            LoadData();
        }

        private void btnDelsanh_Click(object sender, EventArgs e)
        {
            SanhBUS.Instance.Delete(txtMasanh);
            LoadData();
        }
    }
}

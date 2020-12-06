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
    public partial class FormChitietMonan : Form
    {
        public FormChitietMonan()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            MonAnBUS.Instance.LoadData(dgvChitietMonan);
            AddBinding();
        }
        void AddBinding()
        {
            txtMamonan.DataBindings.Clear();
            txtTenmonan.DataBindings.Clear();
            txtLoaimonan.DataBindings.Clear();
            txtMatiec.DataBindings.Clear();
            txtDongiamonan.DataBindings.Clear();
            txtSoluongmonan.DataBindings.Clear();
            txtThanhtienmonan.DataBindings.Clear();
            txtGhichu.DataBindings.Clear();

            txtMamonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "MaMonAn");
            txtTenmonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "TenMonAn");
            txtLoaimonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "LoaiMonAn");
            txtMatiec.DataBindings.Add("Text", dgvChitietMonan.DataSource, "MaTiec");
            txtDongiamonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "DonGia");
            txtSoluongmonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "SoLuong");
            txtThanhtienmonan.DataBindings.Add("Text", dgvChitietMonan.DataSource, "ThanhTien");
            txtGhichu.DataBindings.Add("Text", dgvChitietMonan.DataSource, "GhiChu");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa thành công!");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MonAnBUS.Instance.Insert(txtMatiec, txtMamonan, txtTenmonan, txtLoaimonan, txtDongiamonan, txtSoluongmonan, txtThanhtienmonan, txtGhichu);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MonAnBUS.Instance.Delete(txtMamonan);
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MonAnBUS.Instance.Update(txtMatiec, txtMamonan, txtTenmonan, txtLoaimonan, txtDongiamonan, txtSoluongmonan, txtThanhtienmonan, txtGhichu);
            LoadData();
        }
    }
}

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
    public partial class FormChitietDV : Form
    {
        public FormChitietDV()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            DichVuBUS.Instance.LoadData(dgvChitietDV);
            AddBinDing();
        }
        void AddBinDing()
        {
            txtMatiec.DataBindings.Clear();
            txtMadichvu.DataBindings.Clear();
            txtTendichvu.DataBindings.Clear();
            txtLoaidichvu.DataBindings.Clear();
            txtDongiadichvu.DataBindings.Clear();
            txtSoluongdichvu.DataBindings.Clear();
            txtThanhtiendichvu.DataBindings.Clear();
            txtGhichu.DataBindings.Clear();

            txtMatiec.DataBindings.Add("Text", dgvChitietDV.DataSource, "MaTiec");
            txtMadichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "MaDV");
            txtTendichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "TenDV");
            txtLoaidichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "LoaiDV");
            txtDongiadichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "DonGia");
            txtSoluongdichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "SoLuong");
            txtThanhtiendichvu.DataBindings.Add("Text", dgvChitietDV.DataSource, "ThanhTien");
            txtGhichu.DataBindings.Add("Text", dgvChitietDV.DataSource, "GhiChu");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DichVuBUS.Instance.Update(txtMatiec, txtMadichvu, txtTendichvu, txtLoaidichvu, txtDongiadichvu, txtSoluongdichvu, txtThanhtiendichvu, txtGhichu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DichVuBUS.Instance.Insert(txtMatiec, txtMadichvu, txtTendichvu, txtLoaidichvu, txtDongiadichvu, txtSoluongdichvu, txtThanhtiendichvu, txtGhichu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DichVuBUS.Instance.Delete(txtMadichvu);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

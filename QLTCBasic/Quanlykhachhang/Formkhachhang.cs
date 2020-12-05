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
    public partial class Formkhachhang : Form
    {
        public Formkhachhang()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            KhachHangBUS.Instance.LoadKH(dgvKhach);
            AddBinding();
        }
        void AddBinding()
        {
            txtTenkhach.DataBindings.Clear();
            txtMakhach.DataBindings.Clear();
            txtDiachi.DataBindings.Clear();
            txtCMND.DataBindings.Clear();
            cmbStatuskhach.DataBindings.Clear();
            cmbTypekhach.DataBindings.Clear();

            txtTenkhach.DataBindings.Add("Text", dgvKhach.DataSource, "HoTen");
            txtMakhach.DataBindings.Add("Text", dgvKhach.DataSource, "MaKH");
            txtDiachi.DataBindings.Add("Text", dgvKhach.DataSource, "DiaChi");
            txtCMND.DataBindings.Add("Text", dgvKhach.DataSource, "CMND");
            cmbStatuskhach.DataBindings.Add("Text", dgvKhach.DataSource, "TinhTrangHoSo");
            cmbTypekhach.DataBindings.Add("Text", dgvKhach.DataSource, "LoaiThanhVien");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAddkhach_Click(object sender, EventArgs e)
        {
            KhachHangBUS.Instance.Insert(txtMakhach, txtTenkhach, txtNgaysinh, txtDiachi, txtCMND, cmbTypekhach, cmbStatuskhach);
            LoadData();
        }

        private void btnEditkhach_Click(object sender, EventArgs e)
        {
            KhachHangBUS.Instance.Update(txtMakhach, txtTenkhach, txtNgaysinh, txtDiachi, txtCMND, cmbTypekhach, cmbStatuskhach);
            LoadData();
        }

        private void btnDelkhach_Click(object sender, EventArgs e)
        {
            KhachHangBUS.Instance.Delete(txtMakhach);
            LoadData();
        }
    }
}

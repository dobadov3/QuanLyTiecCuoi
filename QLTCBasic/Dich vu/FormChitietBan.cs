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
    public partial class FormChitietBan : Form
    {
        public FormChitietBan()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            BanBUS.Instance.LoadData(dgvChitietban);
            AddBinDing();
        }
        void AddBinDing()
        {
            txtMatiec.DataBindings.Clear();
            txtMaban.DataBindings.Clear();
            txtTenban.DataBindings.Clear();
            txtLoaiban.DataBindings.Clear();
            txtDongiaban.DataBindings.Clear();
            txtSoluongban.DataBindings.Clear();
            txtSobandutru.DataBindings.Clear();
            txtSobandutruused.DataBindings.Clear();
            txtThanhtienban.DataBindings.Clear();
            txtGhichu.DataBindings.Clear();

            txtMatiec.DataBindings.Add("Text", dgvChitietban.DataSource, "MaTiec");
            txtMaban.DataBindings.Add("Text", dgvChitietban.DataSource, "MaBan");
            txtTenban.DataBindings.Add("Text", dgvChitietban.DataSource, "TenBan");
            txtLoaiban.DataBindings.Add("Text", dgvChitietban.DataSource, "LoaiBan");
            txtDongiaban.DataBindings.Add("Text", dgvChitietban.DataSource, "DonGia");
            txtSoluongban.DataBindings.Add("Text", dgvChitietban.DataSource, "SoLuongBan");
            txtSobandutru.DataBindings.Add("Text", dgvChitietban.DataSource, "DuTru");
            txtSobandutruused.DataBindings.Add("Text", dgvChitietban.DataSource, "DaDung");
            txtThanhtienban.DataBindings.Add("Text", dgvChitietban.DataSource, "ThanhTien");
            txtGhichu.DataBindings.Add("Text", dgvChitietban.DataSource, "GhiChu");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            BanBUS.Instance.Update(txtMatiec, txtMaban, txtTenban, txtLoaiban, txtDongiaban, txtSoluongban, txtSobandutruused, txtSobandutru, txtThanhtienban, txtGhichu);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BanBUS.Instance.Insert(txtMatiec, txtMaban, txtTenban, txtLoaiban, txtDongiaban, txtSoluongban, txtSobandutruused, txtSobandutru, txtThanhtienban, txtGhichu);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            BanBUS.Instance.Delete(txtMaban);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

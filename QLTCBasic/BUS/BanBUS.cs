using QLTCBasic.DAL;
using QLTCBasic.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTCBasic.BUS
{
    class BanBUS
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static BanBUS instance;
        public static BanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void LoadData(DataGridView data)
        {
            data.DataSource = BanDAO.Instance.ListTable();
        }
        public void Insert(TextBox tbMatiec, TextBox tbMaBan, TextBox tbTenBan, TextBox tbLoaiBan, TextBox tbDonGia, TextBox tbSoLuong, TextBox tbDaDung, TextBox tbDuTru, TextBox tbThanhTien, TextBox tbGhiChu)
        {
            if(tbMatiec.Text == "" || tbMaBan.Text == "" || tbTenBan.Text == "" || tbLoaiBan.Text == "" || tbDonGia.Text == "" || tbSoLuong.Text == "" || tbDuTru.Text == "" || tbDaDung.Text == "" || tbThanhTien.Text == "")
            {
                MessageBox.Show("Thông tin bàn không được để trống");
            }
            else
            {
                if (BanDAO.Instance.Insert(tbMatiec.Text, tbMaBan.Text, tbTenBan.Text, tbLoaiBan.Text, int.Parse(tbDonGia.Text), int.Parse(tbSoLuong.Text), int.Parse(tbDuTru.Text), int.Parse(tbDaDung.Text), int.Parse(tbThanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Thêm bàn thành công");
                }
                else
                {
                    MessageBox.Show("Mã bàn đã tồn tại");
                }
            }
        }
        public void Delete(TextBox tbMaBan)
        {
            if (BanDAO.Instance.Delete(tbMaBan.Text))
            {
                MessageBox.Show("Xóa bàn thành công");
            }
            else
            {
                MessageBox.Show("Mã bàn không tồn tại");
            }
        }
        public void Update(TextBox tbMatiec, TextBox tbMaBan, TextBox tbTenBan, TextBox tbLoaiBan, TextBox tbDonGia, TextBox tbSoLuong, TextBox tbDaDung, TextBox tbDuTru, TextBox tbThanhTien, TextBox tbGhiChu)
        {
            if (tbMatiec.Text == "" || tbMaBan.Text == "" || tbTenBan.Text == "" || tbLoaiBan.Text == "" || tbDonGia.Text == "" || tbSoLuong.Text == "" || tbDuTru.Text == "" || tbDaDung.Text == "" || tbThanhTien.Text == "")
            {
                MessageBox.Show("Thông tin bàn không được để trống");
            }
            else
            {
                if (BanDAO.Instance.Update(tbMatiec.Text, tbMaBan.Text, tbTenBan.Text, tbLoaiBan.Text, int.Parse(tbDonGia.Text), int.Parse(tbSoLuong.Text), int.Parse(tbDuTru.Text), int.Parse(tbDaDung.Text), int.Parse(tbThanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Sửa bàn thành công");
                }
                else
                {
                    MessageBox.Show("Mã bàn không tồn tại");
                }
            }
        }
    }
}

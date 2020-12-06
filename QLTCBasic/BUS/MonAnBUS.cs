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
    class MonAnBUS
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static MonAnBUS instance;
        public static MonAnBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonAnBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public void LoadData(DataGridView data)
        {
            data.DataSource = MonAnDao.Instance.ListFood();
        }
        public void Insert(TextBox tbMaTiec, TextBox tbMaMonAn, TextBox tbTenMonAn, TextBox tbLoaiMonAn, TextBox tbDonGia, TextBox tbSoLuong, TextBox tbThanhTien, TextBox tbGhiChu)
        {
            if(tbMaTiec.Text == "" || tbMaMonAn.Text == "" || tbTenMonAn.Text == "" || tbLoaiMonAn.Text == "" || tbDonGia.Text == "" || tbSoLuong.Text == "" || tbThanhTien.Text == "")
            {
                MessageBox.Show("Thông tin món ăn không được để trống");
            }
            else
            {
                if (MonAnDao.Instance.Insert(tbMaTiec.Text, tbMaMonAn.Text, tbTenMonAn.Text, tbLoaiMonAn.Text, int.Parse(tbDonGia.Text), int.Parse(tbSoLuong.Text), int.Parse(tbThanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã món ăn đã tồn tại");
                }
            }
        }
        public void Delete(TextBox tbMaMonAn)
        {
            if (tbMaMonAn.Text == "")
            {
                MessageBox.Show("Mã món ăn không được để trống");
            }
            else
            {
                if (MonAnDao.Instance.Delete(tbMaMonAn.Text))
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Mã món ăn không tồn tại");
                }
            }
        }
        public void Update(TextBox tbMaTiec, TextBox tbMaMonAn, TextBox tbTenMonAn, TextBox tbLoaiMonAn, TextBox tbDonGia, TextBox tbSoLuong, TextBox tbThanhTien, TextBox tbGhiChu)
        {
            if (tbMaTiec.Text == "" || tbMaMonAn.Text == "" || tbTenMonAn.Text == "" || tbLoaiMonAn.Text == "" || tbDonGia.Text == "" || tbSoLuong.Text == "" || tbThanhTien.Text == "")
            {
                MessageBox.Show("Thông tin món ăn không được để trống");
            }
            else
            {
                if (MonAnDao.Instance.Update(tbMaTiec.Text, tbMaMonAn.Text, tbTenMonAn.Text, tbLoaiMonAn.Text, int.Parse(tbDonGia.Text), int.Parse(tbSoLuong.Text), int.Parse(tbThanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Mã món ăn không tồn tại");
                }
            }
        }
    }
}

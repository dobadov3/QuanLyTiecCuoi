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
    class DichVuBUS
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static DichVuBUS instance;
        public static DichVuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void LoadData(DataGridView data)
        {
            data.DataSource = DichVuDAO.Instance.ListService();
        }
        public void Insert(TextBox tbMaTiec, TextBox tbMaDV, TextBox tbtenDV, TextBox tbLoaiDV, TextBox tbDonGia,TextBox soLuong, TextBox tbthanhTien, TextBox tbGhiChu)
        {
            if(tbMaTiec.Text == "" || tbMaDV.Text == "" || tbtenDV.Text == "" || tbLoaiDV.Text == "" || tbDonGia.Text == "" || soLuong.Text == "" || tbthanhTien.Text == "")
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống");
            }
            else
            {
                if (DichVuDAO.Instance.Insert(tbMaTiec.Text, tbMaDV.Text, tbtenDV.Text, tbLoaiDV.Text, int.Parse(tbDonGia.Text), int.Parse(soLuong.Text), int.Parse(tbthanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ đã tồn tại");
                }
            }
            
        }
        public void Delete(TextBox tbMaDV)
        {
            if(DichVuDAO.Instance.Delete(tbMaDV.Text))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Mã dịch vụ không tồn tại");
            }
        }
        public void Update(TextBox tbMaTiec, TextBox tbMaDV, TextBox tbtenDV, TextBox tbLoaiDV, TextBox tbDonGia, TextBox soLuong, TextBox tbthanhTien, TextBox tbGhiChu)
        {
            if (tbMaTiec.Text == "" || tbMaDV.Text == "" || tbtenDV.Text == "" || tbLoaiDV.Text == "" || tbDonGia.Text == "" || soLuong.Text == "" || tbthanhTien.Text == "")
            {
                MessageBox.Show("Thông tin dịch vụ không được để trống");
            }
            else
            {
                if (DichVuDAO.Instance.Update(tbMaTiec.Text, tbMaDV.Text, tbtenDV.Text, tbLoaiDV.Text, int.Parse(tbDonGia.Text), int.Parse(soLuong.Text), int.Parse(tbthanhTien.Text), tbGhiChu.Text))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Mã dịch vụ không tồn tại");
                }
            }

        }
    }
}

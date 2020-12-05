using QLTCBasic.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTCBasic.BUS
{
    class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public void LoadKH(DataGridView data)
        {
            data.DataSource = KhachHangDAO.Instance.ListKH();
            data.Columns[0].HeaderText = "Mã khách hàng";
            data.Columns[1].HeaderText = "Tên khách hàng";
            data.Columns[2].HeaderText = "Ngày sinh";
            data.Columns[3].HeaderText = "Địa chỉ";
            data.Columns[5].HeaderText = "Loại thành viên";
            data.Columns[6].HeaderText = "Tình trạng hồ sơ";
        }
        public void Insert(TextBox tbMaKH, TextBox tbTenKH, TextBox tbNgaySinh, TextBox tbDiaChi, TextBox tbCMND, ComboBox cbLoaiTV, ComboBox cbTinhTrangHoSo)
        {
            if (tbMaKH.Text == "" || tbTenKH.Text == "" || tbNgaySinh.Text == "" || tbDiaChi.Text == "" || tbCMND.Text == "")
            {
                MessageBox.Show("Không thể để trống thông tin khách hàng");
            }
            else
            {
                if (KhachHangDAO.Instance.Insert(tbMaKH.Text, tbTenKH.Text, DateTime.Parse(tbNgaySinh.Text), tbDiaChi.Text, tbCMND.Text, cbLoaiTV.Text, cbTinhTrangHoSo.Text))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại");
                }
            }    
        }
        public void Delete(TextBox tbMaKH)
        {
            if (KhachHangDAO.Instance.Delete(tbMaKH.Text))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Mã khách hàng không tồn tại");
            }
        }

        public void Update(TextBox tbMaKH, TextBox tbTenKH, TextBox tbNgaySinh, TextBox tbDiaChi, TextBox tbCMND, ComboBox cbLoaiTV, ComboBox cbTinhTrangHoSo)
        {
            if (tbMaKH.Text == "" || tbTenKH.Text == "" || tbNgaySinh.Text == "" || tbDiaChi.Text == "" || tbCMND.Text == "")
            {
                MessageBox.Show("Không thể để trống thông tin khách hàng");
            }
            else
            {
                if (KhachHangDAO.Instance.Update(tbMaKH.Text, tbTenKH.Text, DateTime.Parse(tbNgaySinh.Text), tbDiaChi.Text, tbCMND.Text, cbLoaiTV.Text, cbTinhTrangHoSo.Text))
                {
                    MessageBox.Show("Sửa thành công");
                }
                else
                {
                    MessageBox.Show("Mã khách hàng không tồn tại");
                }
            }
            
        }
    }
}

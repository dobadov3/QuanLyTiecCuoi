using QLTCBasic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTCBasic.DAO;
using System.Windows.Forms;

namespace QLTCBasic.BUS
{
    class SanhBUS
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static SanhBUS instance;
        public static SanhBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanhBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void LoadSanh(DataGridView data)
        {
            data.DataSource = SanhDAO.Instance.ListSanh();

            data.Columns[0].HeaderText = "Mã sảnh";
            data.Columns[1].HeaderText = "Tên sảnh";
            data.Columns[2].HeaderText = "Loại sảnh";
        }
        public void Insert(TextBox tbMaSanh, TextBox tbTenSanh, ComboBox cbLoaiSanh)
        {
            if(tbMaSanh.Text == "" || tbTenSanh.Text == "" || cbLoaiSanh.Text == "")
            {
                MessageBox.Show("Thông tin sảnh không được để trống");
            }    
            if (SanhDAO.Instance.Insert(tbMaSanh.Text, tbTenSanh.Text, cbLoaiSanh.Text))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Mã sảnh đã tồn tại");
            }
        }
        public void Delete(TextBox tbMaSanh)
        {
            if (SanhDAO.Instance.Delete(tbMaSanh.Text))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Mã sảnh không tồn tại");
            }
        }
        public void Update(TextBox tbMaSanh, TextBox tbTenSanh, ComboBox cbLoaiSanh)
        {
            if (tbMaSanh.Text == "" || tbTenSanh.Text == "" || cbLoaiSanh.Text == "")
            {
                MessageBox.Show("Thông tin sảnh không được để trống");
            }
            if (SanhDAO.Instance.Update(tbMaSanh.Text, tbTenSanh.Text, cbLoaiSanh.Text))
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Mã sảnh không tồn tại");
            }
        }
    }
}

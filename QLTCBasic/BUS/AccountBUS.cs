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
    class AccountBUS
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public void Login(Form form, TextBox tbUser, TextBox tbPass)
        {
            if (AccountDAO.Instance.Login(tbUser.Text, tbPass.Text))
            {
                form.Hide();        
                Main main = new Main();
                main.ShowDialog();
                form.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản");
            }
        }
    }
}

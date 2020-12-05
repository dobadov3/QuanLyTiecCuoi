using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTCBasic.DAL;

namespace QLTCBasic.DAO
{
    class AccountDAO
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public bool Login(string username, string password)
        {
            Account account = (from d in database.Accounts
                               where d.Username == username && d.Passwords == password
                               select d).SingleOrDefault();
            if (account != null)
                return true;
            return false;
        }
    }
}

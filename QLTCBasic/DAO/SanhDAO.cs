using QLTCBasic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCBasic.DAO
{
    class SanhDAO
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static SanhDAO instance;
        public static SanhDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanhDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public Array ListSanh()
        {
            var list = (from d in database.SANHs
                        select new
                        {
                            MaSanh = d.MaSanh,
                            TenSanh = d.TenSanh,
                            LoaiSanh = d.LoaiSanh
                        });
            return list.ToArray();
        }
        public bool Insert(string maSanh, string tenSanh, string loaiSanh)
        {
            var list = (from d in database.SANHs
                        where d.MaSanh == maSanh
                        select d).SingleOrDefault();
            if (list != null)
                return false;
            else
            {
                SANH sanh = new SANH();
                sanh.MaSanh = maSanh;
                sanh.TenSanh = tenSanh;
                sanh.LoaiSanh = loaiSanh;

                database.SANHs.Add(sanh);
                database.SaveChanges();
            }
            return true;
        }
        public bool Delete(string maSanh)
        {
            var list = (from d in database.SANHs
                        where d.MaSanh == maSanh
                        select d).SingleOrDefault();
            if (list == null)
                return false;
            else
            {
                database.SANHs.Remove(list);
                database.SaveChanges();
            }
            return true;
        }
        public bool Update(string maSanh, string tenSanh, string loaiSanh)
        {
            var list = (from d in database.SANHs
                        where d.MaSanh == maSanh
                        select d).SingleOrDefault();
            if (list == null)
                return false;
            else
            {
                list.TenSanh = tenSanh;
                list.LoaiSanh = loaiSanh;
                database.SaveChanges();
            }
            return true;
        }
    }
}

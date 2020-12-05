using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTCBasic.DAL;

namespace QLTCBasic.DAO
{
    class KhachHangDAO
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();

        private static KhachHangDAO instance;
        public static KhachHangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public Array ListKH()
        {
            var list = (from d in database.KHACHHANGs
                        select new
                        {
                            MaKH = d.MaKH,
                            HoTen = d.TenKH,
                            NgaySinh = d.Ngaysinh,
                            DiaChi = d.Diachi,
                            CMND = d.CMND,
                            LoaiThanhVien = d.LoaiThanhvien,
                            TinhTrangHoSo = d.TinhtrangHoso
                        }).ToArray();

            return list;
        }
        public bool Insert(string maKH, string tenKH, DateTime ngaySinh, string diaChi, string cmnd, string loaiTV, string tinhTrangHoSo)
        {
            var list = (from d in database.KHACHHANGs
                        where d.MaKH == maKH
                        select d).SingleOrDefault();
            if (list != null)
                return false;
            else
            {
                KHACHHANG customer = new KHACHHANG();
                customer.MaKH = maKH;
                customer.TenKH = tenKH;
                customer.Ngaysinh = ngaySinh;
                customer.Diachi = diaChi;
                customer.CMND = cmnd;
                customer.TinhtrangHoso = tinhTrangHoSo;
                customer.LoaiThanhvien = loaiTV;

                database.KHACHHANGs.Add(customer);
                database.SaveChanges();
            }
            return true;
        }
        public bool Delete(string maKH)
        {
            var list = (from d in database.KHACHHANGs
                        where d.MaKH == maKH
                        select d).SingleOrDefault();
            if (list == null)
                return false;
            else
            {
                database.KHACHHANGs.Remove(list);
                database.SaveChanges();
            }
            return true;
        }
        public bool Update(string maKH, string tenKH, DateTime ngaySinh, string diaChi, string cmnd, string loaiTV, string tinhTrangHoSo)
        {
            var list = (from d in database.KHACHHANGs
                        where d.MaKH == maKH
                        select d).SingleOrDefault();
            if (list == null)
                return false;
            else
            {
                list.TenKH = tenKH;
                list.Ngaysinh = ngaySinh;
                list.Diachi = diaChi;
                list.CMND = cmnd;
                list.LoaiThanhvien = loaiTV;
                list.TinhtrangHoso = tinhTrangHoSo;

                database.SaveChanges();
            }
            return true;
        }
    }
}

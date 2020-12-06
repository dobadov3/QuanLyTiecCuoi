using QLTCBasic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCBasic.DAO
{
    class MonAnDao
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static MonAnDao instance;
        public static MonAnDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new MonAnDao();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public Array ListFood()
        {
            var list = (from d in database.CHITIETMONANs
                        select new
                        {
                            MaTiec = d.MaTiec,
                            MaMonAn = d.MaMonAN,
                            TenMonAn = d.MONAN.TenMonAn,
                            LoaiMonAn = d.MONAN.LoaiMonAN,
                            DonGia = d.DongiaMonan,
                            SoLuong = d.SLMonan,
                            ThanhTien = d.ThanhTienMonan,
                            GhiChu = d.GhiChu
                        });
            return list.ToArray();
        }
        public MONAN InsertMonAn(string maMonAn, string tenMonAn, string loaiMonAn)
        {
            MONAN monan = (from d in database.MONANs
                           where d.MaMonAn == maMonAn
                           select d).SingleOrDefault();
            MONAN m = new MONAN();
            if (monan != null)
                return null;
            else
            {
                m.MaMonAn = maMonAn;
                m.TenMonAn = tenMonAn;
                m.LoaiMonAN = loaiMonAn;

                database.MONANs.Add(m);
            }
            return m;
        }
        public bool DeleteMonAn(string maMonAn)
        {
            MONAN monan = (from d in database.MONANs
                           where d.MaMonAn == maMonAn
                           select d).SingleOrDefault();
            if (monan == null)
                return false;
            else
            {
                database.MONANs.Remove(monan);
            }
            database.SaveChanges();
            return true;
        }
        public bool UpdateMonAn(string maMonAn, string tenMonAn, string loaiMonAn)
        {
            MONAN monan = (from d in database.MONANs
                           where d.MaMonAn == maMonAn
                           select d).SingleOrDefault();
            if (monan == null)
                return false;
            else
            {
                monan.TenMonAn = tenMonAn;
                monan.LoaiMonAN = loaiMonAn;
            }
            database.SaveChanges();
            return true;
        }
        public bool Insert(string maTiec, string maMonAn, string tenMonAn, string loaiMonAn, int donGia, int soLuong, int thanhTien, string ghiChu)
        {
            MONAN monan = InsertMonAn(maMonAn, tenMonAn, loaiMonAn);
            if (monan == null)
            {
                return false;
            }
            else
            {
                CHITIETMONAN chitiet = new CHITIETMONAN();
                chitiet.MaTiec = maTiec;
                chitiet.MONAN = monan;
                chitiet.DongiaMonan = donGia;
                chitiet.SLMonan = soLuong;
                chitiet.ThanhTienMonan = thanhTien;
                chitiet.GhiChu = ghiChu;

                database.CHITIETMONANs.Add(chitiet);
            }
            database.SaveChanges();
            return true;
        }
        public bool Delete(string maMonAn)
        {
            CHITIETMONAN chitiet = (from d in database.CHITIETMONANs
                                    where d.MONAN.MaMonAn == maMonAn
                                    select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                database.CHITIETMONANs.Remove(chitiet);
                DeleteMonAn(maMonAn);
            }
            database.SaveChanges();
            return true;
        }
        public bool Update(string maTiec, string maMonAn, string tenMonAn, string loaiMonAn, int donGia, int soLuong, int thanhTien, string ghiChu)
        {
            UpdateMonAn(maMonAn, tenMonAn, loaiMonAn);
            CHITIETMONAN chitiet = (from d in database.CHITIETMONANs
                                    where d.MaTiec == maTiec
                                    select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                chitiet.DongiaMonan = donGia;
                chitiet.SLMonan = soLuong;
                chitiet.ThanhTienMonan = thanhTien;
                chitiet.GhiChu = ghiChu;
            }
            database.SaveChanges();
            return true;
        }
    }
}

using QLTCBasic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCBasic.DAO
{
    class DichVuDAO
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static DichVuDAO instance;
        public static DichVuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DichVuDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        public Array ListService()
        {
            var list = (from d in database.CHITIETDVs
                        select new
                        {
                            MaTiec = d.MaTiec,
                            MaDV = d.MaDV,
                            TenDV = d.DICHVU.TenDV,
                            LoaiDV = d.DICHVU.LoaiDV,
                            DonGia = d.DongiaDV,
                            SoLuong = d.SLDichvu,
                            ThanhTien = d.ThanhTienDV,
                            GhiChu = d.GhiChu
                        });
            return list.ToArray();
        }
        public DICHVU InsertBan(string maDV, string tenDV, string loaiDV)
        {
            DICHVU dv = (from d in database.DICHVUs
                       where d.MaDV == maDV
                       select d).SingleOrDefault();
            DICHVU m = new DICHVU();
            if (dv != null)
                return null;
            else
            {
                m.MaDV = maDV;
                m.TenDV = tenDV;
                m.LoaiDV = loaiDV;

                database.DICHVUs.Add(m);
            }
            return m;
        }
        public bool DeleteBan(string maDV)
        {
            DICHVU dv = (from d in database.DICHVUs
                       where d.MaDV == maDV
                       select d).SingleOrDefault();
            if (dv == null)
                return false;
            else
            {
                database.DICHVUs.Remove(dv);
            }
            database.SaveChanges();
            return true;
        }
        public bool UpdateBan(string maDV, string tenDV, string loaiDV)
        {
            DICHVU dv = (from d in database.DICHVUs
                       where d.MaDV == maDV
                       select d).SingleOrDefault();
            if (dv == null)
                return false;
            else
            {
                dv.TenDV = tenDV;
                dv.LoaiDV = loaiDV;
            }
            database.SaveChanges();
            return true;
        }
        public bool Insert(string maTiec, string maDV, string tenDV, string loaiDV, int donGia, int soLuong, int thanhTien, string ghiChu)
        {
            DICHVU dv = InsertBan(maDV, tenDV, loaiDV);
            if (dv == null)
            {
                return false;
            }
            else
            {
                CHITIETDV chitiet = new CHITIETDV();
                chitiet.MaTiec = maTiec;
                chitiet.DICHVU = dv;
                chitiet.DongiaDV = donGia;
                chitiet.SLDichvu = soLuong;
                chitiet.ThanhTienDV = thanhTien;
                chitiet.GhiChu = ghiChu;

                database.CHITIETDVs.Add(chitiet);
            }
            database.SaveChanges();
            return true;
        }
        public bool Delete(string maDV)
        {
            CHITIETDV chitiet = (from d in database.CHITIETDVs
                                  where d.DICHVU.MaDV == maDV
                                  select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                database.CHITIETDVs.Remove(chitiet);
                DeleteBan(maDV);
            }
            database.SaveChanges();
            return true;
        }
        public bool Update(string maTiec, string maDV, string tenDV, string loaiDV, int donGia, int soLuong, int thanhTien, string ghiChu)
        {
            UpdateBan(maDV, tenDV, loaiDV);
            CHITIETDV chitiet = (from d in database.CHITIETDVs
                                  where d.MaTiec == maTiec
                                  select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                chitiet.DongiaDV = donGia;
                chitiet.SLDichvu = soLuong;
                chitiet.ThanhTienDV = thanhTien;
                chitiet.GhiChu = ghiChu;
            }
            database.SaveChanges();
            return true;
        }
    }
}

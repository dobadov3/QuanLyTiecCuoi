using QLTCBasic.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTCBasic.DAO
{
    class BanDAO
    {
        QLTiecCuoiEntities database = new QLTiecCuoiEntities();
        private static BanDAO instance;
        public static BanDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public Array ListTable()
        {
            var list = (from d in database.CHITIETBANs
                        select new
                        {
                            MaTiec = d.MaTiec,
                            MaBan = d.MaBan,
                            TenBan = d.BAN.TenBan,
                            LoaiBan = d.BAN.LoaiBan,
                            DonGia = d.DongiaBan,
                            SoLuongBan = d.SLBan,
                            DuTru = d.Sobandutru,
                            DaDung = d.Sobandutrudadung,
                            ThanhTien = d.ThanhTienBan,
                            GhiChu = d.GhiChu
                        });
            return list.ToArray();
        }
        public BAN InsertBan(string maBan, string tenBan, string loaiBan)
        {
            BAN ban = (from d in database.BANs
                           where d.MaBan == maBan
                           select d).SingleOrDefault();
            BAN m = new BAN();
            if (ban != null)
                return null;
            else
            {
                m.MaBan = maBan;
                m.TenBan = tenBan;
                m.LoaiBan = loaiBan;

                database.BANs.Add(m);
            }
            return m;
        }
        public bool DeleteBan(string maBan)
        {
            BAN ban = (from d in database.BANs
                           where d.MaBan == maBan
                           select d).SingleOrDefault();
            if (ban == null)
                return false;
            else
            {
                database.BANs.Remove(ban);
            }
            database.SaveChanges();
            return true;
        }
        public bool UpdateBan(string maBan, string tenBan, string loaiBan)
        {
            BAN ban = (from d in database.BANs
                           where d.MaBan == maBan
                           select d).SingleOrDefault();
            if (ban == null)
                return false;
            else
            {
                ban.TenBan = tenBan;
                ban.LoaiBan = loaiBan;
            }
            database.SaveChanges();
            return true;
        }
        public bool Insert(string maTiec, string maBan, string tenBan, string loaiBan, int donGia, int soLuong, int duTru,int daDung,int thanhTien, string ghiChu)
        {
            BAN ban = InsertBan(maBan, tenBan, loaiBan);
            if (ban == null)
            {
                return false;
            }
            else
            {
                CHITIETBAN chitiet = new CHITIETBAN();
                chitiet.MaTiec = maTiec;
                chitiet.BAN = ban;
                chitiet.DongiaBan = donGia;
                chitiet.SLBan = soLuong;
                chitiet.Sobandutru = duTru;
                chitiet.Sobandutrudadung = daDung;
                chitiet.ThanhTienBan = thanhTien;
                chitiet.GhiChu = ghiChu;

                database.CHITIETBANs.Add(chitiet);
            }
            database.SaveChanges();
            return true;
        }
        public bool Delete(string maBan)
        {
            CHITIETBAN chitiet = (from d in database.CHITIETBANs
                                    where d.BAN.MaBan == maBan
                                    select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                database.CHITIETBANs.Remove(chitiet);
                DeleteBan(maBan);
            }
            database.SaveChanges();
            return true;
        }
        public bool Update(string maTiec, string maBan, string tenBan, string loaiBan, int donGia, int soLuong, int duTru, int daDung, int thanhTien, string ghiChu)
        {
            UpdateBan(maBan, tenBan, loaiBan);
            CHITIETBAN chitiet = (from d in database.CHITIETBANs
                                    where d.MaTiec == maTiec
                                    select d).SingleOrDefault();
            if (chitiet == null)
                return false;
            else
            {
                chitiet.DongiaBan = donGia;
                chitiet.SLBan = soLuong;
                chitiet.Sobandutru = duTru;
                chitiet.Sobandutrudadung = daDung;
                chitiet.ThanhTienBan = thanhTien;
                chitiet.GhiChu = ghiChu;
            }
            database.SaveChanges();
            return true;
        }
    }
}

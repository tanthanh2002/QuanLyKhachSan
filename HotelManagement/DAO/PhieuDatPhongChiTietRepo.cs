using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuDatPhongChiTietRepo
    {
        private static PhieuDatPhongChiTietRepo instance = new PhieuDatPhongChiTietRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private PhieuDatPhongChiTietRepo() { }

        public static PhieuDatPhongChiTietRepo Instance { get { return instance; } }

        public static PhieuDatPhongChiTietRepo GetInstance() { return instance; }

        public List<PhieuDatPhongChiTiet> showListMaPhieuDatPhong(int maPhong)
        {
            var s = from a in db.PhieuDatPhongChiTiets join b in db.PhieuDatPhongs on a.maphieudatphong equals b.maphieudatphong
                    where a.maphong == maPhong && b.nhanviencheckout == null && b.checkin==true
                    select a;
            return s.ToList();
        }
        public List<PhieuDatPhongChiTiet> showListMaPhong(int maKhachHang)
        {
            var s = from a in db.PhieuDatPhongChiTiets join b in db.PhieuDatPhongs on a.maphieudatphong equals b.maphieudatphong
                    where b.makhachhang == maKhachHang && b.nhanviencheckout == null && b.checkin==true
                    select a;
            return s.ToList();
        }
        public List<PhieuDatPhongChiTiet> listMaPhongByMaPhieuDatPhong(int maphieu)
        {
            var s = from a in db.PhieuDatPhongChiTiets
                    join b in db.PhieuDatPhongs on a.maphieudatphong equals b.maphieudatphong
                    where b.maphieudatphong == maphieu && b.nhanviencheckout == null && b.checkin == true
                    select a;
            return s.ToList();
        }
        public void save(PhieuDatPhongChiTiet chi)
        {
            db.PhieuDatPhongChiTiets.Add(chi);
            db.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuDatPhongRepo
    {
        private static PhieuDatPhongRepo instance = new PhieuDatPhongRepo();
        private HotelManagementEntities db  = new HotelManagementEntities();
        private PhieuDatPhongRepo() { }

        public static PhieuDatPhongRepo getInstance() { return instance; }

        public int save(PhieuDatPhong phieuDatPhong) { 
            db.PhieuDatPhongs.Add(phieuDatPhong);
            db.SaveChanges();

            return phieuDatPhong.maphieudatphong;
        }

        public List<PhieuDatPhong> findByUsername(string username)
        {
            return db.PhieuDatPhongs.Where(p => p.KhachHang.tenkhachhang == username)
                .ToList();
        }

        public PhieuDatPhong findById(int id)
        {
            return db.PhieuDatPhongs.Find(id);
        }

        public void deleteById(int id)
        {
            db.PhieuDatPhongs.Remove(findById(id));
            db.SaveChanges();
        }

        public PhieuDatPhong findByMaKhachHang(int makh)
        {
            return db.PhieuDatPhongs.Where(p => p.makhachhang.Equals(makh)).Single();
        }
        public int getMaPhieuDatPhongByMaKH(int makh)
        {
            PhieuDatPhong phieu = db.PhieuDatPhongs.SingleOrDefault(p => p.makhachhang == makh && p.checkin == true && p.nhanviencheckout == null);
            if (phieu != null)
            {
                return phieu.maphieudatphong;
            }
            else
            {
                return -1;
            }
        }
        public List<PhieuDatPhong> listDSDatPhongCurrent()
        {
            return db.PhieuDatPhongs.Where(p => p.checkin == true && p.nhanviencheckout == null)
                .ToList();
        }
    }
}

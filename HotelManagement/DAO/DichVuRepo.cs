using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class DichVuRepo
    {
        private static DichVuRepo instance = new DichVuRepo();

        private HotelManagementEntities db = new HotelManagementEntities();
        private DichVuRepo()
        {

        }

        public static DichVuRepo getInstance()
        {
            return instance;
        }
        public List<DichVu> showListDVCoHoTroTheoMaKH(int maPhong, int makh)
        {
            var result = from a in db.DichVus
                         join b in db.CungCapDichVus on a.madichvu equals b.madichvu
                         join c in db.LoaiPhongs on b.maloaiphong equals c.maloaiphong
                         join d in db.Phongs on c.maloaiphong equals d.maloaiphong
                         join e in db.PhieuDatPhongChiTiets on d.maphong equals e.maphong
                         join f in db.PhieuDatPhongs on e.maphieudatphong equals f.maphieudatphong
                         where e.maphong == maPhong && f.nhanviencheckout == null && f.checkin == true && f.makhachhang == makh
                         select a;
            return result.ToList();
        }

        public List<DichVu> showListDVKhongHoTroTheoMaKH(int maPhong, int makh)
        {
            var con = from a in db.DichVus
                      join b in db.CungCapDichVus on a.madichvu equals b.madichvu
                      join c in db.LoaiPhongs on b.maloaiphong equals c.maloaiphong
                      join d in db.Phongs on c.maloaiphong equals d.maloaiphong
                      join e in db.PhieuDatPhongChiTiets on d.maphong equals e.maphong
                      join f in db.PhieuDatPhongs on e.maphieudatphong equals f.maphieudatphong
                      where e.maphong == maPhong && f.nhanviencheckout == null && f.checkin == true && f.makhachhang == makh
                      select a;

            var full = from a in db.DichVus
                       select a;

            var result = full.Except(con);
            return result.ToList();
        }
        public double sumDonGiaDV(int soLuong, int madichvu)
        {
            DichVu dv = db.DichVus.SingleOrDefault(p => p.madichvu == madichvu);
            return (double)(dv.gia * soLuong);
        }

        public int getMaDVbyTenDV(string tenDV)
        {
            DichVu dv = db.DichVus.SingleOrDefault(p => p.tendichvu == tenDV);
            return dv.madichvu;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class HoaDonRepo
    {
        private static HoaDonRepo instance = new HoaDonRepo();

        private HotelManagementEntities db = new HotelManagementEntities();
        private HoaDonRepo() { }

        public static HoaDonRepo getInstance() { return instance; }

        public HoaDon findByMaDatPhong(int madatphong)
        {
            return db.HoaDons.SingleOrDefault(p => p.PhieuDatPhong.maphieudatphong == madatphong);
        }


        public List<HoaDon> findByDate(DateTime date)
        {
            return db.HoaDons.Where(p => p.PhieuDatPhong.ngayden == date).ToList();
        }
        public List<HoaDon> getAll()
        {
            var result = from c in db.HoaDons select c;
            return result.ToList();
        }


        public void addInvoice(HoaDon hoaDon)
        {
            db.HoaDons.AddOrUpdate(hoaDon);
            db.SaveChanges();
        }

        public Double tinhtong(DateTime date)
        {
            double tong = 0;
            var hoadonss = instance.findByDate(date);
            foreach (var hoadon in hoadonss)
            {
                tong += hoadon.tongtien;
            }
            return tong;
        }

    }
}

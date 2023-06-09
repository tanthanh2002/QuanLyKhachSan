using System;
using System.Collections.Generic;
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
        public void addInvoice(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
        }
    }
}

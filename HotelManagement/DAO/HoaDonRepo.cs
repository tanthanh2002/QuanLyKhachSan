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
<<<<<<< HEAD

        public List<HoaDon> findByDate(DateTime date)
        {
            return db.HoaDons.Where(p => p.PhieuDatPhong.ngayden == date).ToList();
        }


=======
        public void addInvoice(HoaDon hoaDon)
        {
            db.HoaDons.Add(hoaDon);
            db.SaveChanges();
        }
>>>>>>> 2c228fe13a5bafe1b1d7cd1885943ec88ebf6556
    }
}

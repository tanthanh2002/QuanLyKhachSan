using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class PhieuSuDungDichVuRepo
    {
        private static PhieuSuDungDichVuRepo instance = new PhieuSuDungDichVuRepo();

        private HotelManagementEntities db = new HotelManagementEntities();
        private PhieuSuDungDichVuRepo()
        {

        }

        public static PhieuSuDungDichVuRepo getInstance()
        {
            return instance;
        }
        public void addPhieuSuDungDichVu(PhieuSuDungDichVu phieu)
        {
            db.PhieuSuDungDichVus.Add(phieu);
            db.SaveChanges();
        }
        public int getMaPhieuSuDungDichVuLatest()
        {
            PhieuSuDungDichVu phieu = db.PhieuSuDungDichVus.OrderByDescending(p => p.maphieu).FirstOrDefault();
            if (phieu != null)
            {
                return phieu.maphieu;
            }
            else
            {
                return -1;
            }
        }
    }
}

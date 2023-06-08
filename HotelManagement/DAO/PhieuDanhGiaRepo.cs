using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuDanhGiaRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();

        private static PhieuDanhGiaRepo instance = new PhieuDanhGiaRepo();
        
        private PhieuDanhGiaRepo() { } 
        public static PhieuDanhGiaRepo getInstance() { return instance; }
        public void addTakeFeedback(PhieuDanhGia phieuDanhGia)
        {
            db.PhieuDanhGias.Add(phieuDanhGia);
            db.SaveChanges();
        }
    }
}

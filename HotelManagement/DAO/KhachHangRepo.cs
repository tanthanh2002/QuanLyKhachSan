using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class KhachHangRepo
    {
        private static KhachHangRepo instance = new KhachHangRepo();

        private HotelManagementEntities db = new HotelManagementEntities();
        private KhachHangRepo()
        {
            
        }

        public static KhachHangRepo getInstance()
        {
            return instance;
        }

        public List<KhachHang> getAll()
        {

            var result = from c in db.KhachHangs select c;
            return result.ToList();
        }

        public void save(KhachHang khachhang) { 
            db.KhachHangs.Add(khachhang);
            db.SaveChanges();
        }

        public KhachHang findKhachHangByTaiKhoan(int mataikhoan)
        {
            var result = db.KhachHangs.Where(p => p.mataikhoan == mataikhoan).SingleOrDefault(null);
            return result;
        }
    }
}

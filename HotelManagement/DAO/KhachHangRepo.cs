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


        public KhachHang findByMaTaiKhoan(int mataikhoan)
        {
            return db.KhachHangs.SingleOrDefault(p => p.TaiKhoan.mataikhoan == mataikhoan);
        }

        public KhachHang findByMaKhachHang(int makhachhang)
        {
            return db.KhachHangs.Find(makhachhang);
        }

        //Tan them

        public KhachHang findByCCCD(string CCCD)
        {
            return db.KhachHangs.SingleOrDefault(p => p.cccd == CCCD);
        }

        public List<KhachHang> TTKHfindByMaTaiKhoan(int mataikhoan)
        {
            var c = from a in db.KhachHangs
                    where a.mataikhoan == mataikhoan
                    select a;
            return c.ToList();
        }

        //public KhachHang findByMaTaiKhoan(int matk)
        //{
        //    try
        //    {
        //        return db.KhachHangs.Where(p => p.mataikhoan.Equals(matk)).Single();
        //    }
        //    catch (Exception e)
        //    {
        //        throw new MissingManifestResourceException("username: " + Convert.ToString(matk) + " not found");
        //    }
        //}
    }
}

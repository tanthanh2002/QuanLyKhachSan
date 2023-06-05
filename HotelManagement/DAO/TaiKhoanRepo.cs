using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class TaiKhoanRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();

        private static TaiKhoanRepo instance = new TaiKhoanRepo();
        private TaiKhoanRepo() { }

        public static TaiKhoanRepo getInstance() { return instance; }

        public TaiKhoan findByUsername(String username)
        {
            try
            {
                return db.TaiKhoans.Where(p => p.tentaikhoan.Equals(username)).Single();
            }catch (Exception e) { 
                throw new MissingManifestResourceException("username: " + username + " not found");
            }
        }

        public void save(TaiKhoan taiKhoan)
        {
            db.TaiKhoans.Add(taiKhoan);
            db.SaveChanges();
        }
    }
}

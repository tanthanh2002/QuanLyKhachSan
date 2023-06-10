using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.DAO
{
    internal class NhanVienRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();
        private static NhanVienRepo instance = new NhanVienRepo();
        private NhanVienRepo() { }
        public static NhanVienRepo getInstance() { return instance; }

        public NhanVien findById(int id)
        {
            return db.NhanViens.Find(id);
        }
        
        public void save(NhanVien nhanVien)
        {
            db.NhanViens.AddOrUpdate(nhanVien);
            db.SaveChanges();
        }

        public void update(NhanVien nhanVien) { 
            db.NhanViens.AddOrUpdate(nhanVien) ; db.SaveChanges();
        }
    }
}

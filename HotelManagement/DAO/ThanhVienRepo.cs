using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class ThanhVienRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();
        private static ThanhVienRepo instance = new ThanhVienRepo();
        private ThanhVienRepo() { }

        public static ThanhVienRepo getInstance() { return instance; }

        public List<ThanhVien> findByMaDoan(int madoan)
        {
            return db.ThanhViens.Where(p => p.madoan == madoan).ToList();
        }

        public void save(ThanhVien thanhVien)
        {
            db.ThanhViens.Add(thanhVien);
            db.SaveChanges();
        }

        public void save(List<ThanhVien> list)
        {
            db.ThanhViens.AddRange(list);
            db.SaveChanges();
        }
        
    }
}

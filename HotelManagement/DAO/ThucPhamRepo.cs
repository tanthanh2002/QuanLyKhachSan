using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class ThucPhamRepo
    {
        private static ThucPhamRepo instance = new ThucPhamRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private ThucPhamRepo() { }

        public static ThucPhamRepo Instance { get { return instance; } }

        public static ThucPhamRepo GetInstance() { return instance; }

        public List<ThucPham> showListThucPham()
        {
            var s = from a in db.ThucPhams select a;
            return s.ToList();
        }
    }
}

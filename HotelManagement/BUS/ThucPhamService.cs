using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class ThucPhamService
    {
        private static ThucPhamService instance = new ThucPhamService();

        private ThucPhamRepo repo = ThucPhamRepo.GetInstance();

        public static ThucPhamService getInstance() { return instance; }

        public List<ThucPham> showListThucPham() { return repo.showListThucPham(); }
    }
}

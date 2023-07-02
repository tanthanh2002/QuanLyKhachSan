using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    class KhuyenMaiService
    {
        private static KhuyenMaiService instance = new KhuyenMaiService();

        private KhuyenMaiRepo repo = KhuyenMaiRepo.getInstance();

        public static KhuyenMaiService getInstance() { return instance; }

        public List<KhuyenMai> layDS()
        {
            return repo.LayDS();
        }
        public void suaTTKM(KhuyenMai khuyenMai)
        {
            repo.suaTTKhuyenMai(khuyenMai);
        }
        public void themKM(KhuyenMai khuyenMai)
        {
            repo.themKM(khuyenMai);
        }

    }
}

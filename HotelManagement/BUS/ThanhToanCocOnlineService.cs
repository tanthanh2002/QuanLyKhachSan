using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class ThanhToanCocOnlineService
    {
        private static ThanhToanCocOnlineService instance = new BUS.ThanhToanCocOnlineService();

        private HoaDonRepo repo = HoaDonRepo.getInstance();

        private ThanhToanCocOnlineService() { }
        public static ThanhToanCocOnlineService getInstance() { return instance; }

        public void createInvoice(HoaDon hoaDon)
        {
            repo.addInvoice(hoaDon);
        }
    }
}

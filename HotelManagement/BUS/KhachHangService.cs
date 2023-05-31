using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class KhachHangService
    {
        private static KhachHangService instance = new KhachHangService();

        private KhachHangRepo repo = KhachHangRepo.getInstance();
        private KhachHangService() { }

        public static KhachHangService getInstance() {  return instance; }

        public List<KhachHang> getAll()
        {
            return repo.getAll();
        }
    }
}

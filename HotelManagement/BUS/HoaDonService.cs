using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class HoaDonService
    {
        private static HoaDonService instance = new HoaDonService();
        private HoaDonRepo repo = HoaDonRepo.getInstance();
        private HoaDonService() { }
        public static HoaDonService getInstance() { return  instance; }

        public List<HoaDon> findByDate(DateTime date)
        {
            return repo.findByDate(date);
        }
        public void addInvoice(HoaDon hoaDon) { repo.addInvoice(hoaDon); }
        public Double tinhtong(DateTime date) { return repo.tinhtong(date); }
        public List<HoaDon> getAll() { return repo.getAll(); }


        public HoaDon findByMaPhieuDatPhong(int maphieu)
        {
            return repo.findByMaDatPhong(maphieu);
        }
    }
}

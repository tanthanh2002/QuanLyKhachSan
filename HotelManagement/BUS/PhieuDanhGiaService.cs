using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class PhieuDanhGiaService
    {
        private static PhieuDanhGiaService instance = new BUS.PhieuDanhGiaService();

        private PhieuDanhGiaRepo repo = PhieuDanhGiaRepo.getInstance();

        private PhieuDanhGiaService() { }
        public static PhieuDanhGiaService getInstance() { return instance; }
        public void addTakeFeedback(PhieuDanhGia phieuDanhGia)
        {
            repo.addTakeFeedback(phieuDanhGia);
        }
    }
}

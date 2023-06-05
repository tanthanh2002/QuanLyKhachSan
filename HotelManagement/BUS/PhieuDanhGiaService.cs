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
        private static PhieuDanhGiaService _instance = new BUS.PhieuDanhGiaService();
        private PhieuDanhGiaRepo _repo = PhieuDanhGiaRepo.getInstace();
        private PhieuDanhGiaService() { }
        public static PhieuDanhGiaService getInstance() { return _instance; }
        public void themDanhGia(PhieuDanhGia phieuDanhGia)
        {
            try
            {

            }
            catch(Exception)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class PhieuDatPhongService
    {
        private static PhieuDatPhongService instance = new PhieuDatPhongService();

        private PhieuDatPhongRepo repo = PhieuDatPhongRepo.getInstance();

        public static PhieuDatPhongService getInstance() { return instance; }

        public int getMaPhieuDatPhongByMaKH(int makh) { return repo.getMaPhieuDatPhongByMaKH(makh); }
        public List<PhieuDatPhong> listDSDatPhongCurrent()
        {
            return repo.listDSDatPhongCurrent();
        }
    }
}

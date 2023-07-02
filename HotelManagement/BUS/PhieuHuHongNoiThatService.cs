using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class PhieuHuHongNoiThatService
    {
        private static PhieuHuHongNoiThatService instance = new PhieuHuHongNoiThatService();

        private PhieuHuHongNoiThatChiTietRepo repo = PhieuHuHongNoiThatChiTietRepo.getInstance();

        public static PhieuHuHongNoiThatService getInstance() { return instance; }

        public int getMaNoiThat(string tennoithat) { return repo.getMaNoiThat(tennoithat); }
        public double calGiaTienDen(int manoithat) { return repo.calGiaTienDen(manoithat); }
        public void addPhieuHuHongNoiThatChiTiet(PhieuHuHongNoiThat phieu)
        {
            repo.addPhieuHuHongNoiThatChiTiet(phieu);
        }

        public float tongTienHuHong(int maphieudatphong)
        {
            return (float) repo.getByMaPhieuDatPhong(maphieudatphong).Sum(p => p.giatienden);
        }
    }
}

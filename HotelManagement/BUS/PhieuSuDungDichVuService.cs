using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class PhieuSuDungDichVuService
    {
        private static PhieuSuDungDichVuService instance = new PhieuSuDungDichVuService();

        private PhieuSuDungDichVuRepo repo = PhieuSuDungDichVuRepo.getInstance();

        private PhieuSuDungDichVuChiTietService phieuSuDungDichVuChiTietService = PhieuSuDungDichVuChiTietService.getInstance();

        public static PhieuSuDungDichVuService getInstance() { return instance; }
        public int addPhieuSuDungDichVu(PhieuSuDungDichVu phieu) { return repo.addPhieuSuDungDichVu(phieu); }

        public int MaPhieuSuDungDichVuLatest() { return repo.getMaPhieuSuDungDichVuLatest(); }

        public float tongTienDichVu(int maphieudatphong)
        {
            List<PhieuSuDungDichVuChiTiet> listPhieuSuDungDVChiTiet = phieuSuDungDichVuChiTietService.GetChiTietList(maphieudatphong);
            float tongtien = (float)listPhieuSuDungDVChiTiet.Sum(p => p.dongia);
            return tongtien;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class PhieuDatPhongChiTietService
    {
        private static PhieuDatPhongChiTietService instance = new PhieuDatPhongChiTietService();

        private PhieuDatPhongChiTietRepo repo = PhieuDatPhongChiTietRepo.GetInstance();

        public static PhieuDatPhongChiTietService getInstance() { return instance; }

        public List<PhieuDatPhongChiTiet> showListMaPhieuDatPhong(int maPhong) { return repo.showListMaPhieuDatPhong(maPhong); }

        public List<PhieuDatPhongChiTiet> showListMaPhong(int maKhachHang) { return repo.showListMaPhong(maKhachHang); }

        public List<PhieuDatPhongChiTiet> listMaPhongByMaPhieuDatPhong(int maphieu)
        {
            return repo.listMaPhongByMaPhieuDatPhong(maphieu);
        }
        public void themPhieuDPCT(PhieuDatPhongChiTiet phieuDatPhong)
        {
            repo.save(phieuDatPhong);
        }
    }
}

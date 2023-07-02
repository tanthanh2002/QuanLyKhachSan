using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class PhieuSuDungThucPhamService
    {
        private static PhieuSuDungThucPhamService instance = new PhieuSuDungThucPhamService();

        private PhieuSuDungThucPhamRepo repo = PhieuSuDungThucPhamRepo.getInstance();

        public static PhieuSuDungThucPhamService getInstance() { return instance; }

        public int getMaThucPham(string tenthucpham) { return repo.getMaThucPham(tenthucpham); }
        public double sumDonGia(int soLuong, int mathucpham) { return repo.sumDonGia(soLuong, mathucpham); }
        public void addPhieuSuDungThucPham(PhieuSuDungThucPham phieu)
        {
            repo.addPhieuSuDungThucPham(phieu);
        }

        public List<PhieuSuDungThucPham> getByMaPhieuDatPhong(int maphieudatphong)
        {
            return repo.getByMaPhieuDatPhong(maphieudatphong);
        }

        public float tongTienThucPham(int maphieudatphong)
        {
            return (float) repo.getByMaPhieuDatPhong(maphieudatphong).Sum(p => p.dongia);
        }
    }
}

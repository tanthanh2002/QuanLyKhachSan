using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class DichVuService
    {
        private static DichVuService instance = new DichVuService();

        private DichVuRepo repo = DichVuRepo.getInstance();

        public static DichVuService getInstance() { return instance; }

        public List<DichVu> showListDVCoHoTroTheoMaKH(int maPhong, int makh) { return repo.showListDVCoHoTroTheoMaKH(maPhong, makh); }

        public List<DichVu> showListDVKhongHoTroTheoMaKH(int maPhong, int makh) { return repo.showListDVKhongHoTroTheoMaKH(maPhong, makh); }

        public double sumDonGiaDV(int soLuong, int madichvu) { return repo.sumDonGiaDV(soLuong, madichvu); }

        public int getMaDVbyTenDV(string tenDV) { return repo.getMaDVbyTenDV(tenDV); }
        public List<DichVu> showListDVCoHoTroTheoMaPhieuDat(int maPhong, int maphieu) { return repo.showListDVCoHoTroTheoMaPhieuDat(maPhong, maphieu); }
        public List<DichVu> showListDVKhongHoTroTheoMaPhieuDat(int maPhong, int maphieu) { return repo.showListDVKhongHoTroTheoMaPhieuDat(maPhong, maphieu); }
        public List<DichVu> getAllByTenDV(string tenDV)
        {
            return repo.getAllByTenDV(tenDV);
        }
        public List<DichVu> showListDVCoHoTroTheoMaPhieuDatTimKiem(int maPhong, int maphieu, string tenDV)
        {
            return repo.showListDVCoHoTroTheoMaPhieuDatTimKiem(maPhong, maphieu, tenDV);
        }

        public List<DichVu> showListDVKhongHoTroTheoMaPhieuDatTimKiem(int maPhong, int maphieu, string tenDV)
        {
            return repo.showListDVKhongHoTroTheoMaPhieuDatTimKiem(maPhong, maphieu, tenDV);
        }
    }
}

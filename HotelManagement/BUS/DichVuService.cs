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

        public double sumDonGiaDV(int soLuong, int madichvu) { return sumDonGiaDV(soLuong, madichvu); }

        public int getMaDVbyTenDV(string tenDV) { return getMaDVbyTenDV(tenDV); }
    }
}

using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class PhieuSuDungDichVuChiTietService
    {
        private static PhieuSuDungDichVuChiTietService instance = new BUS.PhieuSuDungDichVuChiTietService();

        private PhieuSuDungDichVuChiTietRepo repo = PhieuSuDungDichVuChiTietRepo.getInstance();

        private PhieuSuDungDichVuChiTietService() { }
        public static PhieuSuDungDichVuChiTietService getInstance () { return instance; }

        public List<PhieuSuDungDichVuChiTiet> GetChiTietList(int maPhieuDatPhong)
        {
            return repo.getChiTietList (maPhieuDatPhong);
        }
        public void addPhieuSuDungDichVuChiTiet(PhieuSuDungDichVuChiTiet phieu) { repo.addPhieuSuDungDichVuChiTiet(phieu); }
    }
}

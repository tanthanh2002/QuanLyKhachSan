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
        public List<PhieuSuDungDichVuChiTiet> DSDichVufindByMaDatPhong(int madat) { return repo.DSDichVufindByMaDatPhong(madat); }
        
        public List<PhieuSuDungDichVuChiTiet> getAll()
        {
                return repo.getAll();
        }
        public List<PhieuSuDungDichVuChiTiet> getAllByMaPhieuDatPhong(int maphieu) { return repo.getAllByMaPhieuDatPhong(maphieu); }
    }
}

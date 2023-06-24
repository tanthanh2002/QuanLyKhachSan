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

        public static PhieuSuDungDichVuService getInstance() { return instance; }
        public void addPhieuSuDungDichVu(PhieuSuDungDichVu phieu) { repo.addPhieuSuDungDichVu(phieu); }

        public int MaPhieuSuDungDichVuLatest() { return repo.getMaPhieuSuDungDichVuLatest(); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuSuDungDichVuChiTietRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();
        
        private static PhieuSuDungDichVuChiTietRepo instance = new PhieuSuDungDichVuChiTietRepo();

        private PhieuSuDungDichVuChiTietRepo() { }

        public static PhieuSuDungDichVuChiTietRepo getInstance () { return instance; }

        public List<PhieuSuDungDichVuChiTiet> getChiTietList(int maPhieuDatPhong)
        {
            int maPhieu = 0;
            maPhieu = db.PhieuSuDungDichVus.Where(p => p.maphieudatphong == maPhieuDatPhong).Select(p=>p.maphieu).FirstOrDefault();
            return db.PhieuSuDungDichVuChiTiets.Where(p=>p.maphieusudungdichvu == maPhieu ).ToList();
        }
        public void addPhieuSuDungDichVuChiTiet(PhieuSuDungDichVuChiTiet phieu)
        {
            db.PhieuSuDungDichVuChiTiets.Add(phieu);
            db.SaveChanges();
        }
        public List<PhieuSuDungDichVuChiTiet> DSDichVufindByMaDatPhong(int madat)
        {
            var result = from a in db.PhieuSuDungDichVuChiTiets
                         join b in db.PhieuSuDungDichVus on a.maphieusudungdichvu equals b.maphieu
                         where b.maphieudatphong == madat
                         select a;
            return result.ToList();
        }
        public List<PhieuSuDungDichVuChiTiet> getAll()
        {
            var result = from a in db.PhieuSuDungDichVuChiTiets
                         select a;
            return result.ToList();
        }
        public List<PhieuSuDungDichVuChiTiet> getAllByMaPhieuDatPhong(int maphieu)
        {
            var result = from a in db.PhieuSuDungDichVuChiTiets
                         join b in db.PhieuSuDungDichVus on a.maphieusudungdichvu equals b.maphieu
                         where b.maphieudatphong == maphieu
                         select a;
            return result.ToList();
        }
    }
}

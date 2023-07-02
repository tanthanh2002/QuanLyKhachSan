using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class PhieuSuDungThucPhamRepo
    {
        private HotelManagementEntities db = new HotelManagementEntities();

        private static PhieuSuDungThucPhamRepo instance = new PhieuSuDungThucPhamRepo();

        private PhieuSuDungThucPhamRepo() { }

        public static PhieuSuDungThucPhamRepo getInstance() { return instance; }

        public int getMaThucPham(string tenthucpham)
        {
            ThucPham thucPham = db.ThucPhams.SingleOrDefault(p => p.tenthucpham == tenthucpham);
            if( thucPham != null)
            {
                return thucPham.mathucpham;
            }
            else
            {
                return -1;
            }
        }
        public double sumDonGia(int soLuong, int mathucpham)
        {
            ThucPham thucPham = db.ThucPhams.SingleOrDefault(p => p.mathucpham == mathucpham);
            if (thucPham != null)
            {
                return (double)(thucPham.gia * soLuong);
            }
            else
            {
                return -1;
            }
            
        }
        public void addPhieuSuDungThucPham(PhieuSuDungThucPham phieu)
        {
            db.PhieuSuDungThucPhams.Add(phieu);
            db.SaveChanges();
        }


        public List<PhieuSuDungThucPham> getByMaPhieuDatPhong(int phieu)
        {
            return db.PhieuSuDungThucPhams.Where( p => p.maphieudatphong == phieu ).ToList() ;
        }
    }
}

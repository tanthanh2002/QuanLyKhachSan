using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class DatTourRepo
    {
        private static DatTourRepo instance = new DatTourRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private DatTourRepo() { }

        public static DatTourRepo Instance { get { return instance; } }

        public static DatTourRepo GetInstance() { return instance; }

        public List<DatTour> DSDatTourfindByMaTaiKhoan(int mataikhoan)
        {
            var result = from a in db.DatTours
                         join b in db.KhachHangs on a.makhachhang equals b.makhachhang
                         join c in db.TourDuLiches on a.matour equals c.matour
                         where b.mataikhoan == mataikhoan
                         select a;
            //select new
            //{
            //    c.tentour,
            //    c.gia,
            //    a
            //};
            return result.ToList();
        }

        public void addDatTour(DatTour dattour)
        {
            db.DatTours.Add(dattour);
            db.SaveChanges();
        }

        public List<DatTour> getAll()
        {
            var result = from a in db.DatTours
                         select a;
            return result.ToList();
        }

        public List<DatTour> getByMaKH(int makh)
        {
            var result = from a in db.DatTours
                         where a.makhachhang == makh
                         select a;
            return result.ToList();
        }
    }
}

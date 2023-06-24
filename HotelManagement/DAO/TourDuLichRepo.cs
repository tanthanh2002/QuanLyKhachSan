using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class TourDuLichRepo
    {
        private static TourDuLichRepo instance = new TourDuLichRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private TourDuLichRepo() { }

        public static TourDuLichRepo Instance { get { return instance; } }

        public static TourDuLichRepo GetInstance() { return instance; }

        public List<TourDuLich> dsTour()
        {
            return db.TourDuLiches.ToList();
        }
        public List<TourDuLich> getAllByTenTour(string tenTour)
        {
            var result = from a in db.TourDuLiches
                         where a.tentour.Contains(tenTour)
                         select a;
            return result.ToList();
        }
    }
}

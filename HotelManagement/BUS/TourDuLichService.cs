using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class TourDuLichService
    {
        private static TourDuLichService instance = new TourDuLichService();

        private TourDuLichRepo repo = TourDuLichRepo.GetInstance();

        public static TourDuLichService getInstance() { return instance; }

        public List<TourDuLich> dsTour() { return repo.dsTour(); }
        public List<TourDuLich> getAllByTenTour(string tenTour)
        {
            return repo.getAllByTenTour(tenTour);
        }
    }
}

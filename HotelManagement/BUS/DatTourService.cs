using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class DatTourService
    {
        private static DatTourService instance = new DatTourService();

        private DatTourRepo repo = DatTourRepo.GetInstance();

        public static DatTourService getInstance() { return instance; }

        public List<DatTour> DSDatTourfindByMaTaiKhoan(int mataikhoan) { return repo.DSDatTourfindByMaTaiKhoan(mataikhoan); }

        public void addDatTour(DatTour dattour)
        {
            repo.addDatTour(dattour);
        }
    }
}

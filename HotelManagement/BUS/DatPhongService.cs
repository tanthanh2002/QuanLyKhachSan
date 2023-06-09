using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class DatPhongService
    {
        private static DatPhongService instace = new BUS.DatPhongService();
    
        private PhieuDatPhongRepo repo = PhieuDatPhongRepo.getInstance();

        private DatPhongService() { }
        public static DatPhongService getInstance() {  return instace; }
        public void addRoomBook(PhieuDatPhong phieuDatPhong)
        {
            repo.save(phieuDatPhong);
        }
    }
}

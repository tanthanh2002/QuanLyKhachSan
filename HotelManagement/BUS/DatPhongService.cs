using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    public class DatPhongService
    {
        private static DatPhongService instance = new DatPhongService();

        private PhieuDatPhongRepo repo = PhieuDatPhongRepo.getInstance();

        private DatPhongService() { }

        public static DatPhongService getInstance() { return instance; }

        public void addRoomBook(PhieuDatPhong phieuDatPhong)
        {
            repo.save(phieuDatPhong);
        }
        //public DatPhongService findByMaKhachHang(int makh)
        //{
        //    return repo.findByMaKhachHang(makh);
        //}
    }
}

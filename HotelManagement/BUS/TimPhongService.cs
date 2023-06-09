using HotelManagement.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.BUS
{
    internal class TimPhongService
    {
        private static TimPhongService instance = new BUS.TimPhongService();

        private PhongRepo repo = PhongRepo.GetInstance();

        private TimPhongService() { }
        public static TimPhongService getInstance() {  return instance; }

        public List<Phong> GetPhongList(float theoGia, int theoSoPhong)
        {
            return repo.findAll(theoGia, theoSoPhong);
        }


    }
}

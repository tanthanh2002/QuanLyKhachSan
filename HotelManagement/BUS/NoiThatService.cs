using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagement.DAO;

namespace HotelManagement.BUS
{
    class NoiThatService
    {
        private static NoiThatService instance = new NoiThatService();

        private NoiThatRepo repo = NoiThatRepo.GetInstance();

        public static NoiThatService getInstance() { return instance; }

        public List<NoiThat> showListNoiThat(int maPhong) { return repo.showListNoiThat(maPhong); }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    internal class NoiThatRepo
    {
        private static NoiThatRepo instance = new NoiThatRepo();
        private HotelManagementEntities db = new HotelManagementEntities();
        private NoiThatRepo() { }

        public static NoiThatRepo Instance { get { return instance; } }

        public static NoiThatRepo GetInstance() { return instance; }

        public List<NoiThat> showListNoiThat(int maPhong)
        {
            var s = from a in db.NoiThats where a.maphong == maPhong select a;
            return s.ToList();
        }

    }
}

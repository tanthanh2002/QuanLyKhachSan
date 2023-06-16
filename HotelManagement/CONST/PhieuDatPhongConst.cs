using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.CONST
{
    class PhieuDatPhongConst
    {
        private static PhieuDatPhong curUser;

        public static void setMaPhieu(PhieuDatPhong maPhieu)
        {
            curUser = maPhieu;
        }

        public static PhieuDatPhong getMaPhieu()
        {
            return curUser;
        }
    }
}

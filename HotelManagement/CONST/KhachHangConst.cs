using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.CONST
{
    class KhachHangConst
    {
        private static KhachHang curUser;

        public static void setKH(KhachHang khachhang)
        {
            curUser = khachhang;
        }

        public static KhachHang getKH()
        {
            return curUser;
        }
    }
}

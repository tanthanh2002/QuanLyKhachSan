using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.CONST
{
    class TaiKhoanConst
    {
        private static TaiKhoan curUser;

        public static void setUser(TaiKhoan taiKhoan)
        {
            curUser = taiKhoan;
        }

        public static TaiKhoan getUser()
        {
            return curUser;
        }
    }
}

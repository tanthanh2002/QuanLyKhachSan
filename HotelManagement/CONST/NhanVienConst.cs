using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.CONST
{
    class NhanVienConst
    {
        private static NhanVien curUser;

        public static void setNV(NhanVien nv)
        {
            curUser = nv;
        }

        public static NhanVien getNV()
        {
            return curUser;
        }
    }
}

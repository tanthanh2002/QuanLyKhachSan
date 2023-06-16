using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.DAO
{
    public class DichVu
    {
        private static DichVu instance = new DichVu();

        private HotelManagementEntities db = new HotelManagementEntities();
        private DichVu()
        {

        }

        public static DichVu getInstance()
        {
            return instance;
        }
        //public List<DichVu> getDVCoHoTroTheoMaKH(int makh)
        //{

        //    //
        //}



    }
}

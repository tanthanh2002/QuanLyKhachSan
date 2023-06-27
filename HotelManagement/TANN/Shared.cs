using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.TANN
{
    public class Shared
    {
    }
    public class datPhongSelected
    {
        public int _maPhong { get; set; }
        public decimal _gia { get; set; }
        public datPhongSelected(int maphong, decimal gia)
        {
            _maPhong = maphong;
            _gia = gia;
        }
    }
    public class onlinePaymentInf
    {

        public int _maDP { get; set;}
        public double? _tongTien { get; set;}
        
      
        public onlinePaymentInf(int maPhieuDP, double? tongtien)
        {
            _maDP = maPhieuDP;
            _tongTien = tongtien;
        }
    }
}

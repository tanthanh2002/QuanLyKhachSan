//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class HoaDon
    {
        public int mahoadon { get; set; }
        public Nullable<double> tiendichvu { get; set; }
        public double tienthucpham { get; set; }
        public double tienhuhongnoithat { get; set; }
        public double tongtien { get; set; }
        public double sotiendathanhtoan { get; set; }
        public int maphieudatphong { get; set; }
        public Nullable<int> maketoan { get; set; }
        public string tinhtrang { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhieuDatPhong PhieuDatPhong { get; set; }
    }
}

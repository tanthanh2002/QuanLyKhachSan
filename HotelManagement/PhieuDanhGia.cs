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
    
    public partial class PhieuDanhGia
    {
        public int maphieudanhgia { get; set; }
        public string noidung { get; set; }
        public int diem { get; set; }
        public int makhachhang { get; set; }
        public int maphieudatphong { get; set; }
    
        public virtual KhachHang KhachHang { get; set; }
        public virtual PhieuDatPhong PhieuDatPhong { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETHOADON
    {
        public int MaHD { get; set; }
        public int MaMenu { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public int SoLuong { get; set; }
        public Nullable<double> GiamGia { get; set; }
        public Nullable<double> GiaBan { get; set; }
    
        public virtual HOADON HOADON { get; set; }
        public virtual MENU MENU { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV_VC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NhanVien
    {
        public string MaNV { get; set; }
        public string HoNV { get; set; }
        public string TenNV { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public Nullable<int> Luong { get; set; }
        public string AnhNV { get; set; }
        public string DiaChi { get; set; }
        public string MaPB { get; set; }
    
        public virtual PhongBan PhongBan { get; set; }
    }
}
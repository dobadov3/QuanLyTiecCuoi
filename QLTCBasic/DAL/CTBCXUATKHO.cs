//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTCBasic.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTBCXUATKHO
    {
        public string MaBCXuatkho { get; set; }
        public string MaSanh { get; set; }
        public string MaBCThuchi { get; set; }
        public string Tennguoinhap { get; set; }
        public Nullable<System.DateTime> Ngayxuatkho { get; set; }
        public Nullable<int> Tongchiphixuat { get; set; }
    
        public virtual CTBCTHUCHITHEONGAY CTBCTHUCHITHEONGAY { get; set; }
        public virtual SANH SANH { get; set; }
    }
}

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
    
    public partial class KHACHHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.HOPDONGs = new HashSet<HOPDONG>();
            this.TIECCUOIs = new HashSet<TIECCUOI>();
        }
    
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public string CMND { get; set; }
        public string LoaiThanhvien { get; set; }
        public string TinhtrangHoso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIECCUOI> TIECCUOIs { get; set; }
    }
}

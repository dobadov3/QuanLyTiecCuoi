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
    
    public partial class CTBCTHUCHITHEONGAY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTBCTHUCHITHEONGAY()
        {
            this.CTBCBAOTRISANHs = new HashSet<CTBCBAOTRISANH>();
            this.CTBCNHAPKHOes = new HashSet<CTBCNHAPKHO>();
            this.CTBCXUATKHOes = new HashSet<CTBCXUATKHO>();
            this.TIECCUOIs = new HashSet<TIECCUOI>();
        }
    
        public string MaBCThuchi { get; set; }
        public string MaBCDoanhthuthang { get; set; }
        public Nullable<System.DateTime> ngaybaocao { get; set; }
        public Nullable<int> Chiphitochuc { get; set; }
        public Nullable<int> Thanhtienthuvao { get; set; }
        public Nullable<int> Tongketdoanhthu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBCBAOTRISANH> CTBCBAOTRISANHs { get; set; }
        public virtual CTBCDOANHTHUTHEOTHANG CTBCDOANHTHUTHEOTHANG { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBCNHAPKHO> CTBCNHAPKHOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBCXUATKHO> CTBCXUATKHOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIECCUOI> TIECCUOIs { get; set; }
    }
}

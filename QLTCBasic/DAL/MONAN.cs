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
    
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            this.CHITIETMONANs = new HashSet<CHITIETMONAN>();
        }
    
        public string MaMonAn { get; set; }
        public string TenMonAn { get; set; }
        public string LoaiMonAN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETMONAN> CHITIETMONANs { get; set; }
    }
}
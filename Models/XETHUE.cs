//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace chothuexe1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class XETHUE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XETHUE()
        {
            this.CHITIETHOADONs = new HashSet<CHITIETHOADON>();
            this.DANHGIAs = new HashSet<DANHGIA>();
            this.TAIKHOANs = new HashSet<TAIKHOAN>();
        }
    
        public int MaXe { get; set; }
        public string TenXe { get; set; }
        public string HangXe { get; set; }
        public string LoaiXe { get; set; }
        public string MoTa { get; set; }
        public string BienSo { get; set; }
        public decimal GiaThue { get; set; }
        public string TrangThai { get; set; }
        public string AnhDaiDien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHOADON> CHITIETHOADONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIA> DANHGIAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOANs { get; set; }
    }
}

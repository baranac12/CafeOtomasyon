//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeOtomasyon.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class İçecekler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public İçecekler()
        {
            this.Siparis = new HashSet<Siparis>();
        }
    
        public int id { get; set; }
        public int KategoriId { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public bool Durum { get; set; }
    
        public virtual İçecekKategori İçecekKategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}

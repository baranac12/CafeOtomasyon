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
    
    public partial class Siparis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Siparis()
        {
            this.Hesap = new HashSet<Hesap>();
            this.SiparisDurumu = new HashSet<SiparisDurumu>();
        }
    
        public int id { get; set; }
        public Nullable<int> YemekId { get; set; }
        public Nullable<int> TatliId { get; set; }
        public Nullable<int> İcecekId { get; set; }
        public int MasaNo { get; set; }
        public int KullaniciId { get; set; }
        public string Durum { get; set; }
        public decimal Tutar { get; set; }
        public Nullable<int> Tür { get; set; }
        public Nullable<System.DateTime> VerilmeTarihi { get; set; }
        public Nullable<System.DateTime> TeslimTarihi { get; set; }
        public Nullable<System.DateTime> OnaylanmaTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hesap> Hesap { get; set; }
        public virtual İçecekler İçecekler { get; set; }
        public virtual kullanici kullanici { get; set; }
        public virtual Masa Masa { get; set; }
        public virtual Tatlı Tatlı { get; set; }
        public virtual Yemek Yemek { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SiparisDurumu> SiparisDurumu { get; set; }
    }
}

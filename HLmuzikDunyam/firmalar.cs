//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HLmuzikDunyam
{
    using System;
    using System.Collections.Generic;
    
    public partial class firmalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public firmalar()
        {
            this.bankalar = new HashSet<bankalar>();
            this.satinAlma = new HashSet<satinAlma>();
        }
    
        public short firmaID { get; set; }
        public string ad { get; set; }
        public string yetkiliDepartman { get; set; }
        public string yetkiliAdSoyad { get; set; }
        public string telefon1 { get; set; }
        public string telefon2 { get; set; }
        public string telefon3 { get; set; }
        public string mail { get; set; }
        public string fax { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public string vergiDaire { get; set; }
        public string adres { get; set; }
        public Nullable<bool> firmaDurum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bankalar> bankalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<satinAlma> satinAlma { get; set; }
    }
}

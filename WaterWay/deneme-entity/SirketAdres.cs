//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace deneme_entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class SirketAdres
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SirketAdres()
        {
            this.Sirket = new HashSet<Sirket>();
        }
    
        public int SirketAdresID { get; set; }
        public string Mahalle { get; set; }
        public string Sokak { get; set; }
        public string Ilce { get; set; }
        public string Il { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sirket> Sirket { get; set; }
    }
}

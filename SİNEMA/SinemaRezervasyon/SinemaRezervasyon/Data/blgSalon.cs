//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SinemaRezervasyon.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class blgSalon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public blgSalon()
        {
            this.blgFilms = new HashSet<blgFilm>();
            this.blgSeans = new HashSet<blgSean>();
            this.tblSatis = new HashSet<tblSati>();
        }
    
        public int Id { get; set; }
        public string SalonNo { get; set; }
        public Nullable<int> KoltukSayisi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blgFilm> blgFilms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<blgSean> blgSeans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSati> tblSatis { get; set; }
    }
}

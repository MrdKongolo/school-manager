//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetroUI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eleve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Eleve()
        {
            this.Payes = new HashSet<Paye>();
            this.Recus = new HashSet<Recu>();
        }
    
        public string MatriculeEl { get; set; }
        public string Nom { get; set; }
        public string PostNom { get; set; }
        public string Prenom { get; set; }
        public string CodeClasse { get; set; }
        public Nullable<System.DateTime> DateNaissance { get; set; }
        public string Sexe { get; set; }
    
        public virtual Class Class { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paye> Payes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recu> Recus { get; set; }
    }
}

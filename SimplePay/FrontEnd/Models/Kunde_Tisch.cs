//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FrontEnd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kunde_Tisch
    {
        public Kunde_Tisch()
        {
            this.Bestellung = new HashSet<Bestellung>();
        }
    
        public int kt_id { get; set; }
        public int t_id { get; set; }
        public int k_id { get; set; }
    
        public virtual ICollection<Bestellung> Bestellung { get; set; }
        public virtual Tisch Tisch { get; set; }
    }
}

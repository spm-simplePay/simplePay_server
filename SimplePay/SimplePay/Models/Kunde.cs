//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimplePay.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    
    public partial class Kunde
    {
        public Kunde()
        {
            this.Bestellung = new HashSet<Bestellung>();
            this.Kunde_Tisch = new HashSet<Kunde_Tisch>();
        }
    
        public int k_id { get; set; }
        public System.DateTime eingetragen_am { get; set; }

        public virtual ICollection<Bestellung> Bestellung { get; set; }
        public virtual ICollection<Kunde_Tisch> Kunde_Tisch { get; set; }
    }
}

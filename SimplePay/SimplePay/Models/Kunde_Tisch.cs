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
    
    public partial class Kunde_Tisch
    {
        public Kunde_Tisch()
        {
            this.Bestellung = new HashSet<Bestellung>();
        }
    
        public int kt_id { get; set; }
        public int t_id { get; set; }
        public int k_id { get; set; }

        [JsonIgnore]
        public virtual ICollection<Bestellung> Bestellung { get; set; }
        [JsonIgnore]
        public virtual Kunde Kunde { get; set; }
        public virtual Tisch Tisch { get; set; }
    }
}

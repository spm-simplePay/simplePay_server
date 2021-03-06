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
    
    public partial class Haendler
    {
        public Haendler()
        {
            this.Provision = new HashSet<Provision>();
        }
    
        public int h_ID { get; set; }
        public string name { get; set; }
        public System.DateTime eingetragen_am { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
        public int a_id { get; set; }
        public int ha_id { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        public virtual Haendlerart Haendlerart { get; set; }
        public virtual ICollection<Provision> Provision { get; set; }
    }
}

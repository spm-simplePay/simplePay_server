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
    
    public partial class Zusatz
    {
        public Zusatz()
        {
            this.Produkt_Zusatz = new HashSet<Produkt_Zusatz>();
        }
    
        public int z_id { get; set; }
        public string bezeichnung { get; set; }
        public System.DateTime eingetragen_am { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
    
        public virtual ICollection<Produkt_Zusatz> Produkt_Zusatz { get; set; }
    }
}

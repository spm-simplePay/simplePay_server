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
    
    public partial class MwSt_Satz
    {
        public MwSt_Satz()
        {
            this.Bestellung = new HashSet<Bestellung>();
        }
    
        public int mwst_id { get; set; }
        public double satz { get; set; }
        public System.DateTime eingetragen_am { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
    
        public virtual ICollection<Bestellung> Bestellung { get; set; }
    }
}

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
    
    public partial class Rechnung
    {
        public int r_id { get; set; }
        public System.DateTime datum { get; set; }
        public System.TimeSpan uhrzeit { get; set; }
        public bool bezahlt { get; set; }
        public int b_id { get; set; }
    
        public virtual Bestellung Bestellung { get; set; }
    }
}

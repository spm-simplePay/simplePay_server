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
    
    public partial class Bestellposition
    {
        public int bp_id { get; set; }
        public int menge { get; set; }
        public System.DateTime datum { get; set; }
        public System.TimeSpan uhrzeit { get; set; }
        public int p_id { get; set; }
        public int b_id { get; set; }
    
        [JsonIgnore]
        public virtual Bestellung Bestellung { get; set; }
        public virtual Produkt Produkt { get; set; }
    }
}

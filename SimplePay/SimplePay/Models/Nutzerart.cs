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
    
    public partial class Nutzerart
    {
        public Nutzerart()
        {
            this.Nutzer = new HashSet<Nutzer>();
        }
    
        public int na_id { get; set; }
        public string bezeichnung { get; set; }
        public System.DateTime eingetragen_am { get; set; }
    
        public virtual ICollection<Nutzer> Nutzer { get; set; }
    }
}

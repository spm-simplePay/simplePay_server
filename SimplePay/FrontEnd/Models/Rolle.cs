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
    
    public partial class Rolle
    {
        public Rolle()
        {
            this.Mitarbeiter = new HashSet<Mitarbeiter>();
        }
    
        public int ro_id { get; set; }
        public string bezeichnung { get; set; }
        public System.DateTime eingetragen_am { get; set; }
    
        public virtual ICollection<Mitarbeiter> Mitarbeiter { get; set; }
    }
}
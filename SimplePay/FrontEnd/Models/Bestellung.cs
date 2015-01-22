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
    
    public partial class Bestellung
    {
        public Bestellung()
        {
            this.Bestellposition = new HashSet<Bestellposition>();
            this.Rechnung = new HashSet<Rechnung>();
        }
    
        public int b_id { get; set; }
        public System.DateTime datum { get; set; }
        public System.TimeSpan uhrzeit { get; set; }
        public int k_id { get; set; }
        public int mwst_id { get; set; }
        public int m_id { get; set; }
        public int kt_id { get; set; }
        public Nullable<bool> erledigt { get; set; }
    
        public virtual ICollection<Bestellposition> Bestellposition { get; set; }
        public virtual Kunde Kunde { get; set; }
        public virtual Kunde_Tisch Kunde_Tisch { get; set; }
        public virtual Mitarbeiter Mitarbeiter { get; set; }
        public virtual MwSt_Satz MwSt_Satz { get; set; }
        public virtual ICollection<Rechnung> Rechnung { get; set; }
    }
}
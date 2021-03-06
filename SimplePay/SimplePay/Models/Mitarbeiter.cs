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
    
    public partial class Mitarbeiter
    {
        public Mitarbeiter()
        {
            this.Bestellung = new HashSet<Bestellung>();
        }
    
        public int m_id { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public string nutzername { get; set; }
        public byte[] passwort { get; set; }
        public System.DateTime eingetragen_am { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
        public int ro_id { get; set; }
    
        [JsonIgnore]
        public virtual ICollection<Bestellung> Bestellung { get; set; }
        public virtual Rolle Rolle { get; set; }
    }
}

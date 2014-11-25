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
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Adresse
    {
        public Adresse()
        {
            this.Haendler = new HashSet<Haendler>();
            this.Nutzer = new HashSet<Nutzer>();
        }
    
        public int a_id { get; set; }
        public string strasse { get; set; }
        public string hausnummer { get; set; }
        public int plz { get; set; }
        public string ort { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
        //gut gemacht
        [JsonIgnore]
        public virtual ICollection<Haendler> Haendler { get; set; }
        [JsonIgnore]
        public virtual ICollection<Nutzer> Nutzer { get; set; }
    }
}

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
    
    public partial class Nutzer
    {
        public int n_id { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public System.DateTime geburtstag { get; set; }
        public string email { get; set; }
        public byte[] passwort { get; set; }
        public byte[] paypin { get; set; }
        public System.DateTime eingetragen_am { get; set; }
        public Nullable<System.DateTime> geaendert_am { get; set; }
        public int a_id { get; set; }
        public int na_id { get; set; }
    
        public virtual Adresse Adresse { get; set; }
        [JsonIgnore]
        public virtual Nutzerart Nutzerart { get; set; }
    }
}

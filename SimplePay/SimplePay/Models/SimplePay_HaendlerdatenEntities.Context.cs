﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SimplePay_HaendlerdatenEntities : DbContext
    {
        public SimplePay_HaendlerdatenEntities()
            : base("name=SimplePay_HaendlerdatenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Bestellposition> Bestellposition { get; set; }
        public DbSet<Bestellung> Bestellung { get; set; }
        public DbSet<Kategorie> Kategorie { get; set; }
        public DbSet<Kunde> Kunde { get; set; }
        public DbSet<Kunde_Tisch> Kunde_Tisch { get; set; }
        public DbSet<Mitarbeiter> Mitarbeiter { get; set; }
        public DbSet<MwSt_Satz> MwSt_Satz { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Produkt_Kategorie> Produkt_Kategorie { get; set; }
        public DbSet<Produkt_Zusatz> Produkt_Zusatz { get; set; }
        public DbSet<Rechnung> Rechnung { get; set; }
        public DbSet<Rolle> Rolle { get; set; }
        public DbSet<Tisch> Tisch { get; set; }
        public DbSet<Zusatz> Zusatz { get; set; }
    }
}
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
    
    public partial class SimplePay_StammdatenEntities : DbContext
    {
        public SimplePay_StammdatenEntities()
            : base("name=SimplePay_StammdatenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Adresse> Adresse { get; set; }
        public DbSet<Haendler> Haendler { get; set; }
        public DbSet<Haendlerart> Haendlerart { get; set; }
        public DbSet<Nutzer> Nutzer { get; set; }
        public DbSet<Nutzerart> Nutzerart { get; set; }
        public DbSet<Provision> Provision { get; set; }
    }
}

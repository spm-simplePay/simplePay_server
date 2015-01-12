using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplePay.Models;
using SimplePay.Controllers;
using System.Collections.Generic;
using System.Transactions;

namespace SimplePay.Test
{
    [TestClass]
    public class UnitTest2
    {

        TransactionScope _trans;

        /*
         * Wird vor dem Tests aufgeruden, so dass die DAten nicht dauerhaft in die DB geschrieben werden
         */
        [TestInitialize()]
        public void Init()
        {
            _trans = new TransactionScope();

        }

        /*
         * Wird nach dem Test aufgerufen, so dass die Daten nicht dauerhaft in die DB geschrieben werden
         */
        [TestCleanup()]
        public void Cleanup()
        {
            _trans.Dispose();
        }



        /*
        *Diese Testmethode prüft die Abfrage des Produktangebots
        */
        [TestMethod]
        public void Get_Produkt_Menu()
        {
            ProduktController produktController = new ProduktController();
            IEnumerable <Produkt> produkte = produktController.Get();
            if (produkte == null)
            {
                throw new Exception();
            }
        }

        /*
        * Diese Testmethode prüft die Abfrage der Tagesangebote
        */
        [TestMethod]
        public void Get_Tagesangebot()
        {
            TagesangebotController tagesangebotController = new TagesangebotController();
            IEnumerable<Tagesangebot> tagesangebote = tagesangebotController.Get();
            if (tagesangebote == null)
            {
                throw new Exception();
            }
        }

        /*
        * Diese Testmethode prüft ob das Anlegen einer BEstellung problemlos funktioniert
         */
        [TestMethod]
        public void Write_Bestellung()
        {
            BestellungController bestellungController = new BestellungController();

            Bestellposition bestellposition1 = new Bestellposition();
            Bestellposition bestellposition2 = new Bestellposition();

            bestellposition1.menge = 1;
            bestellposition1.p_id = 1;

            bestellposition2.menge = 2;
            bestellposition2.p_id = 2;

            List<Bestellposition> bestellpositionen = new List<Bestellposition>();
            bestellpositionen.Add(bestellposition1);
            bestellpositionen.Add(bestellposition2);


            Kunde_Tisch kunde_tisch = new Kunde_Tisch();
            kunde_tisch.t_id = 1;
            kunde_tisch.k_id = 1;

            Bestellung bestellung = new Bestellung();

            bestellung.Bestellposition = bestellpositionen;
            bestellung.Kunde_Tisch = kunde_tisch;
            bestellung.k_id = 1;
            bestellung.mwst_id = 1;

            bestellungController.Post(bestellung);
           




        }


    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplePay.Models;
using SimplePay.Controllers;
using System.Collections.Generic;
using System.Transactions;

namespace SimplePay.Tests
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

    }
}

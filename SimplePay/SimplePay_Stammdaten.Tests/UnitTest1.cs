using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimplePay.Models;
using SimplePay.Controllers;
using System.Collections.Generic;
using System.Transactions;


namespace SimplePay_Stammdaten.Tests
{
    [TestClass]
    public class UnitTest1
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
         *Diese Testmethode prüft die Registrierung 
         */
        [TestMethod]
        public void User_Registration()
        {
            //Testnutzer wird erstellt
            Nutzer nutzer = new Nutzer();
            //nutzer.email = "test@simplepay.com";
            nutzer.email = "test@simplepay.com";
            nutzer.passwort = "123";
            nutzer.vorname = "Max";
            nutzer.nachname = "Mustermann";
            nutzer.geburtstag = new System.DateTime(1980,01,01);
            nutzer.eingetragen_am = DateTime.Now;
            nutzer.paypin = "1234";
            nutzer.na_id = 1;

            //Testadresse wird erstellt
            Adresse adresse = new Adresse();
            
            adresse.hausnummer = "123";
            adresse.plz = 78136;
            adresse.ort= "Teststadt";
            adresse.geaendert_am = DateTime.Now;
            adresse.Nutzer = null;
            adresse.Haendler = null;
            nutzer.Adresse = adresse;
            
            //Controller wird initialisiert
            RegController regController = new RegController();
            
            //Bei diesem Test kann die Adresse nicht angelegt werden, da die Straße fehlt
            //Bei diesem Test muss man den key 1 zurückbekommen
            KeyValuePair<int, string> notCompleteRegistration = regController.Post(nutzer);
            if (notCompleteRegistration.Key != 1)
            {
                throw new Exception();
            }

            adresse.strasse = "Teststraße";
            
            KeyValuePair<int, string> sucessRegistration = regController.Post(nutzer);
            //Bei diesem Test kann der Nutzer und die Adresse erfolgreich angelegt werden
            //Bei diesem Test muss der key 0 zurückkommen
            if (sucessRegistration.Key != 0)
            {
                throw new Exception();
            }

            //Gegencheck -- Falls der Nutzer schon da ist muss der Wert 2 zurück kommen
            //Bei diesem Test kann der Nutzer und die Adresse nicht angelegt werden, da die E-Mail-Adresse bereits vergeben ist
            //Bei diesem Test muss der key 2 zurückkommen
            KeyValuePair<int, string> doubleRegistration = regController.Post(nutzer);
            if (doubleRegistration.Key != 2)
            {
                throw new Exception();
            }

        }
    }
}

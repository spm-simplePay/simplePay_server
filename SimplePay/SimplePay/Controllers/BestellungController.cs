using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class BestellungController : ApiController
    {
        SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();

        // GET api/bestellung
        public Bestellung Get()
        {
            List<Bestellung> bestellungen = db.Bestellung.ToList();
            Bestellung bestellung = bestellungen[0];
            return bestellung;
        }

        // GET api/bestellung/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/bestellung
        public Bestellung Post(Bestellung bestellung)
        {

            db.Kunde_Tisch.Add(bestellung.Kunde_Tisch);
            bestellung.kt_id = bestellung.Kunde_Tisch.kt_id;

            bestellung.m_id = holeMitarbeiterID();
            bestellung.datum = System.DateTime.Now;
            bestellung.uhrzeit = System.DateTime.Now.TimeOfDay;

            
            IEnumerable<Bestellposition> bestellpositionen = bestellung.Bestellposition;
            foreach (Bestellposition bestellposition in bestellpositionen)
            {
                bestellposition.b_id = bestellung.b_id;
                bestellposition.datum = System.DateTime.Now;
                bestellposition.uhrzeit = System.DateTime.Now.TimeOfDay;
            }

            db.Bestellung.Add(bestellung);
            db.SaveChanges();

            foreach (Bestellposition bestellposition in bestellpositionen)
            {
                bestellposition.Produkt = db.Produkt.Find(bestellposition.p_id);
            }

            speicherRechnung(bestellung.b_id);


            return bestellung;             
        }


        // PUT api/bestellung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bestellung/5
        public void Delete(int id)
        {
        }

        //sucht freien Mitarbeiter
        private int holeMitarbeiterID()
        {

            int menge = 1000000000;
            int id = 1;
            IEnumerable<Mitarbeiter> mitarbeiterAlle = db.Mitarbeiter;
            foreach (Mitarbeiter mitarbeiter in mitarbeiterAlle)
            {
                if (mitarbeiter.ro_id == 1)
                {
    
                    if (db.Bestellung.Count<Bestellung>(a => a.m_id == mitarbeiter.m_id) < menge)
                    {
                        
                        menge = db.Bestellung.Count<Bestellung>(a => a.m_id == id);
                        id = mitarbeiter.m_id;
                    }
                }
            }

            return id;

        }

        //anlegen und speichern einer Rechnung zur Bestellung
        private void speicherRechnung(int b_id)
        {
            Rechnung rechnung = new Rechnung();
            rechnung.b_id = b_id;
            rechnung.bezahlt = true;
            rechnung.datum = System.DateTime.Now;
            rechnung.uhrzeit = System.DateTime.Now.TimeOfDay;

            db.Rechnung.Add(rechnung);
            db.SaveChanges();
    
        }

    }
}

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
        public void Post(Bestellung bestellung)
        {
            db.Kunde_Tisch.Add(bestellung.Kunde_Tisch);
            bestellung.kt_id = bestellung.Kunde_Tisch.kt_id;
           
            bestellung.m_id = 1;
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
                
        }

        // PUT api/bestellung/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/bestellung/5
        public void Delete(int id)
        {
        }
    }
}

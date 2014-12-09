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

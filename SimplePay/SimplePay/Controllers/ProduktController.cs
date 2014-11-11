using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class ProduktController : ApiController
    {
        SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();
        // GET api/produkt
        public IEnumerable<Produkt> Get()
        {
            return db.Produkt.ToList();
        }

        // GET api/produkt/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/produkt
        public void Post([FromBody]string value)
        {
        }

        // PUT api/produkt/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/produkt/5
        public void Delete(int id)
        {
        }
    }
}

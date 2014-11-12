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
        public IEnumerable<Produkt> Get(int id)
        {
            //Kategorie kategorie = db.Kategorie.Find(id);

            return db.Produkt.ToList();
           
            //List<Produkt> produkte =
            //foreach (Produkt produkt in produkte)
            //{
            //    int produkt_kategorie = produkt.p_id;
            //    db.Produkt_Kategorie.
            //}
            

            
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

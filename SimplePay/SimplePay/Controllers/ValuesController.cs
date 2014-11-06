using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class ValuesController : ApiController
    {
        // Dritter Schuss
        SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();
        // GET api/values
        //public IEnumerable<string> Get()
        public IEnumerable<Tisch> Get()
        {
            IEnumerable<Tisch> tisch = db.Tisch.ToList();
            return tisch;


            //return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            Tisch tisch = db.Tisch.Find(id);
            return tisch.bezeichnung;
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
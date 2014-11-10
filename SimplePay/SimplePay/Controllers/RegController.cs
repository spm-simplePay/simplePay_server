using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class RegController : ApiController
    {
        SimplePay_StammdatenEntities db_s = new SimplePay_StammdatenEntities();

        // GET api/reg
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/reg/5
        public Nutzer Get(int id)
        {
            return db_s.Nutzer.Find(id);
        }

        // POST api/reg
        public void Post([FromBody]Nutzer value)
        {
            db_s.Nutzer.Add(value);
            db_s.SaveChanges();
        }

        // PUT api/reg/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/reg/5
        public void Delete(int id)
        {
        }
    }
}

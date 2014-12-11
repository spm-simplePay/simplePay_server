using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class TagesangebotController : ApiController
    {
        SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();
        
        // GET api/tagesangebot
        public IEnumerable<Tagesangebot> Get()
        {
            return db.Tagesangebot.ToList();
        }
        
        // GET api/tagesangebot/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/tagesangebot
        public void Post([FromBody]string value)
        {
        }

        // PUT api/tagesangebot/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/tagesangebot/5
        public void Delete(int id)
        {
        }
    }
}

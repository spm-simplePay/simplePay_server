using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Cryptography;

namespace SimplePay.Controllers
{
    public class LoginController : ApiController
    {

        SimplePay_StammdatenEntities db_s = new SimplePay_StammdatenEntities();

        // GET api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public Nutzer Get(Nutzer nutzer)
        {

            int nutzer_id = nutzer.n_id;
            byte[] nutzer_pw = nutzer.passwort;

            return nutzer;

        }

        // POST api/login
        public void Post([FromBody]string value)
        {
        }

        // PUT api/login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/login/5
        public void Delete(int id)
        {
        }
    }
}

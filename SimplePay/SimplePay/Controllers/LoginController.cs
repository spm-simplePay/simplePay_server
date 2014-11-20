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
        MD5CryptoServiceProvider cryptoService = new MD5CryptoServiceProvider();

        // GET api/login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/login/5
        public Nutzer Get(int id)
        {
            Nutzer nutzer = db_s.Nutzer.Find(id);

            Nutzer loginNutzer = new Nutzer();
            loginNutzer.n_id = nutzer.n_id;
            loginNutzer.a_id = nutzer.a_id;
            loginNutzer.eingetragen_am = nutzer.eingetragen_am;
            loginNutzer.email = nutzer.email;
            loginNutzer.passwort = nutzer.passwort;
            return loginNutzer;

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

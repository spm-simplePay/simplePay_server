using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SimplePay.Controllers
{
    public class QuittungController : ApiController
    {

        SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();


        // GET api/quittung/5
        public IEnumerable<Bestellung> Get(int k_id)
        {
            string sql;
            var quittungen = new List<Bestellung>();
            try
            {
                sql = @"Select * From [Bestellung] WHERE k_id = {0}";
                return quittungen = db.Bestellung.SqlQuery(sql, k_id).ToList<Bestellung>();

            }
            catch
            {
                return null;
            }

        }

    }
}

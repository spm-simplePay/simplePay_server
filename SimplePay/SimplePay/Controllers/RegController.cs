﻿using SimplePay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Security.Cryptography;

namespace SimplePay.Controllers
{
    public class RegController : ApiController
    {
        SimplePay_StammdatenEntities db_s = new SimplePay_StammdatenEntities();
        MD5CryptoServiceProvider cryptoService = new MD5CryptoServiceProvider();


        // GET api/reg
        public IEnumerable<Nutzer> Get()
        {
            
            return db_s.Nutzer.ToList();
        }

        // GET api/reg/5
        public Nutzer Get(int id)
        {
            return db_s.Nutzer.Find(id);
        }

        // POST api/reg
        public String Post([FromBody]Nutzer nutzer)
        {
            Nutzer nutzerCheck = db_s.Nutzer.SingleOrDefault(n => n.email == nutzer.email);
            
            //Prüfung ob die E-Mailadresse bereits vergeben ist
            if(nutzerCheck == null)
            { 
                nutzer.Adresse.geaendert_am = System.DateTime.Now;
                db_s.Adresse.Add(nutzer.Adresse);
                db_s.SaveChanges();


                nutzer.passwort = cryptoService.ComputeHash(nutzer.passwort);
                nutzer.paypin = cryptoService.ComputeHash(nutzer.paypin);
     

                nutzer.eingetragen_am = System.DateTime.Now;
                nutzer.a_id = nutzer.Adresse.a_id;
                db_s.Nutzer.Add(nutzer);
                db_s.SaveChanges();
                return "Ihr Benutzer wurde erfolgreich angelegt";
            }
            else
            {
                return "Diese E-Mail-Adresse ist bereits vergeben";
            }

            

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

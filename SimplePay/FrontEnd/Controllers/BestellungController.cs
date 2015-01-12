using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FrontEnd.Models;

namespace FrontEnd.Controllers
{
    public class BestellungController : Controller
    {
        private SimplePay_HaendlerdatenEntities db = new SimplePay_HaendlerdatenEntities();

        // GET: /Bestellung/
        public ActionResult Index()
        {
            var bestellung = db.Bestellung.Include(b => b.Kunde).Include(b => b.Kunde_Tisch).Include(b => b.Mitarbeiter).Include(b => b.MwSt_Satz).Include(b => b.Bestellposition).OrderByDescending(b => b.datum);
            var bestellung1 = new List<Bestellung>();
            bestellung1 = bestellung.ToList();
            return View(bestellung1);
        }

        // GET: /Bestellung/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestellung bestellung = db.Bestellung.Find(id);
            if (bestellung == null)
            {
                return HttpNotFound();
            }
            return View(bestellung);
        }

        // GET: /Bestellung/Create
        public ActionResult Create()
        {
            ViewBag.k_id = new SelectList(db.Kunde, "k_id", "k_id");
            ViewBag.kt_id = new SelectList(db.Kunde_Tisch, "kt_id", "kt_id");
            ViewBag.m_id = new SelectList(db.Mitarbeiter, "m_id", "vorname");
            ViewBag.mwst_id = new SelectList(db.MwSt_Satz, "mwst_id", "mwst_id");
            return View();
        }

        // POST: /Bestellung/Create
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="b_id,datum,uhrzeit,k_id,mwst_id,m_id,kt_id")] Bestellung bestellung)
        {
            if (ModelState.IsValid)
            {
                db.Bestellung.Add(bestellung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.k_id = new SelectList(db.Kunde, "k_id", "k_id", bestellung.k_id);
            ViewBag.kt_id = new SelectList(db.Kunde_Tisch, "kt_id", "kt_id", bestellung.kt_id);
            ViewBag.m_id = new SelectList(db.Mitarbeiter, "m_id", "vorname", bestellung.m_id);
            ViewBag.mwst_id = new SelectList(db.MwSt_Satz, "mwst_id", "mwst_id", bestellung.mwst_id);
            return View(bestellung);
        }

        // GET: /Bestellung/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestellung bestellung = db.Bestellung.Find(id);
            if (bestellung == null)
            {
                return HttpNotFound();
            }
            ViewBag.k_id = new SelectList(db.Kunde, "k_id", "k_id", bestellung.k_id);
            ViewBag.kt_id = new SelectList(db.Kunde_Tisch, "kt_id", "kt_id", bestellung.kt_id);
            ViewBag.m_id = new SelectList(db.Mitarbeiter, "m_id", "vorname", bestellung.m_id);
            ViewBag.mwst_id = new SelectList(db.MwSt_Satz, "mwst_id", "mwst_id", bestellung.mwst_id);
            return View(bestellung);
        }

        // POST: /Bestellung/Edit/5
        // Aktivieren Sie zum Schutz vor übermäßigem Senden von Angriffen die spezifischen Eigenschaften, mit denen eine Bindung erfolgen soll. Weitere Informationen 
        // finden Sie unter http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="b_id,datum,uhrzeit,k_id,mwst_id,m_id,kt_id")] Bestellung bestellung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bestellung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.k_id = new SelectList(db.Kunde, "k_id", "k_id", bestellung.k_id);
            ViewBag.kt_id = new SelectList(db.Kunde_Tisch, "kt_id", "kt_id", bestellung.kt_id);
            ViewBag.m_id = new SelectList(db.Mitarbeiter, "m_id", "vorname", bestellung.m_id);
            ViewBag.mwst_id = new SelectList(db.MwSt_Satz, "mwst_id", "mwst_id", bestellung.mwst_id);
            return View(bestellung);
        }

        // GET: /Bestellung/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Bestellung bestellung = db.Bestellung.Find(id);
            if (bestellung == null)
            {
                return HttpNotFound();
            }
            return View(bestellung);
        }

        // POST: /Bestellung/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Bestellung bestellung = db.Bestellung.Find(id);
            db.Bestellung.Remove(bestellung);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

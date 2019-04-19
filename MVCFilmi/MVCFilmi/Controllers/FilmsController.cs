using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCFilmi.Models;

namespace MVCFilmi.Controllers
{
    public class FilmsController : Controller
    {
        private MVCFilmiContext db = new MVCFilmiContext();

        // GET: Films
        public ActionResult Index()
        {
            return View(db.Films.ToList());
        }

        // GET: Films/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Films/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Naslov,Izdano,Tip,Cena")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(film);
        }

        // GET: Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Naslov,Izdano,Tip,Cena")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(film);
        }

        // GET: Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Isci (string niz, string ftip)
        {
            var tipList = new List<string>();
            var tipPoizvedba = (from a in db.Films
                               orderby a.Tip
                               select a.Tip).Distinct();
            tipList.AddRange(tipPoizvedba);
            ViewBag.ftip = new SelectList(tipList);

            
            var films = from a in db.Films
                        select a;

            if (!string.IsNullOrEmpty(ftip))
            {
                films = films.Where(s => s.Tip == ftip);
            }
            if (!String.IsNullOrEmpty(niz))
            {
                films = films.Where(s => s.Naslov.Contains(niz));
            }
            return View(films);
        }
        protected override void Dispose(bool disposing)
        {
         
        }
    }
}

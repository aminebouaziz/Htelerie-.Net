using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hotellerie_Amine_.Models.HotellerieModel;

namespace Hotellerie_Amine_.Controllers
{
    public class AppreciationsController : Controller
    {
        private HotellerieDbContext db = new HotellerieDbContext();

        // GET: Appreciations
        public ActionResult Index()
        {
            var appreciations = db.Appreciations.Include(a => a.Hotel);
            return View(appreciations.ToList());
        }

        // GET: Appreciations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appreciation appreciation = db.Appreciations.Find(id);
            if (appreciation == null)
            {
                return HttpNotFound();
            }
            return View(appreciation);
        }

        // GET: Appreciations/Create
        public ActionResult Create()
        {
            ViewBag.HotelId = new SelectList(db.Hotel, "Id", "Nom");
            return View();
        }

        // POST: Appreciations/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NomPers,Commentaire,HotelId")] Appreciation appreciation)
        {
            if (ModelState.IsValid)
            {
                db.Appreciations.Add(appreciation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HotelId = new SelectList(db.Hotel, "Id", "Nom", appreciation.HotelId);
            return View(appreciation);
        }

        // GET: Appreciations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appreciation appreciation = db.Appreciations.Find(id);
            if (appreciation == null)
            {
                return HttpNotFound();
            }
            ViewBag.HotelId = new SelectList(db.Hotel, "Id", "Nom", appreciation.HotelId);
            return View(appreciation);
        }

        // POST: Appreciations/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NomPers,Commentaire,HotelId")] Appreciation appreciation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appreciation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HotelId = new SelectList(db.Hotel, "Id", "Nom", appreciation.HotelId);
            return View(appreciation);
        }

        // GET: Appreciations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appreciation appreciation = db.Appreciations.Find(id);
            if (appreciation == null)
            {
                return HttpNotFound();
            }
            return View(appreciation);
        }

        // POST: Appreciations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appreciation appreciation = db.Appreciations.Find(id);
            db.Appreciations.Remove(appreciation);
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

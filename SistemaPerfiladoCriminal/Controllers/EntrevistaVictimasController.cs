using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaPerfiladoCriminal.Context;
using SistemaPerfiladoCriminal.Models;

namespace SistemaPerfiladoCriminal.Controllers
{
    public class EntrevistaVictimasController : Controller
    {
        private Contexto db = new Contexto();

        // GET: EntrevistaVictimas
        public ActionResult Index()
        {
            return View(db.EntrevistaVictimas.ToList());
        }

        // GET: EntrevistaVictimas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaVictima entrevistaVictima = db.EntrevistaVictimas.Find(id);
            if (entrevistaVictima == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaVictima);
        }

        // GET: EntrevistaVictimas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntrevistaVictimas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre,LstrDescripcion")] EntrevistaVictima entrevistaVictima)
        {
            if (ModelState.IsValid)
            {
                db.EntrevistaVictimas.Add(entrevistaVictima);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrevistaVictima);
        }

        // GET: EntrevistaVictimas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaVictima entrevistaVictima = db.EntrevistaVictimas.Find(id);
            if (entrevistaVictima == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaVictima);
        }

        // POST: EntrevistaVictimas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre,LstrDescripcion")] EntrevistaVictima entrevistaVictima)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrevistaVictima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrevistaVictima);
        }

        // GET: EntrevistaVictimas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaVictima entrevistaVictima = db.EntrevistaVictimas.Find(id);
            if (entrevistaVictima == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaVictima);
        }

        // POST: EntrevistaVictimas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntrevistaVictima entrevistaVictima = db.EntrevistaVictimas.Find(id);
            db.EntrevistaVictimas.Remove(entrevistaVictima);
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

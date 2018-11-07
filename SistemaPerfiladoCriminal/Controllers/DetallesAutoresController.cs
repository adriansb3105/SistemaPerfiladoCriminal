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
    public class DetallesAutoresController : Controller
    {
        private Contexto db = new Contexto();

        // GET: DetallesAutores
        public ActionResult Index()
        {
            return View(db.DetallesAutor.ToList());
        }

        // GET: DetallesAutores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        // GET: DetallesAutores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetallesAutores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrDetalle")] DetallesAutor detallesAutor)
        {
            if (ModelState.IsValid)
            {
                db.DetallesAutor.Add(detallesAutor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detallesAutor);
        }

        // GET: DetallesAutores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        // POST: DetallesAutores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrDetalle")] DetallesAutor detallesAutor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detallesAutor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detallesAutor);
        }

        // GET: DetallesAutores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        // POST: DetallesAutores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            db.DetallesAutor.Remove(detallesAutor);
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

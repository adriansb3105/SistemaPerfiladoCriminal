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
    public class IndiciosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Indicios
        public ActionResult Index()
        {
            return View(db.Indicios.ToList());
        }

        // GET: Indicios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicio indicio = db.Indicios.Find(id);
            if (indicio == null)
            {
                return HttpNotFound();
            }
            return View(indicio);
        }

        // GET: Indicios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Indicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrDescripcion")] Indicio indicio)
        {
            if (ModelState.IsValid)
            {
                db.Indicios.Add(indicio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(indicio);
        }

        // GET: Indicios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicio indicio = db.Indicios.Find(id);
            if (indicio == null)
            {
                return HttpNotFound();
            }
            return View(indicio);
        }

        // POST: Indicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrDescripcion")] Indicio indicio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(indicio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(indicio);
        }

        // GET: Indicios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Indicio indicio = db.Indicios.Find(id);
            if (indicio == null)
            {
                return HttpNotFound();
            }
            return View(indicio);
        }

        // POST: Indicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Indicio indicio = db.Indicios.Find(id);
            db.Indicios.Remove(indicio);
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

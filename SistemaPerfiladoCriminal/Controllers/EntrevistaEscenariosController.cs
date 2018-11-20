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
    public class EntrevistaEscenariosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: EntrevistaEscenarios
        public ActionResult Index()
        {
            return View(db.EntrevistaEscenarios.ToList());
        }

        // GET: EntrevistaEscenarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaEscenario entrevistaEscenario = db.EntrevistaEscenarios.Find(id);
            if (entrevistaEscenario == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaEscenario);
        }

        // GET: EntrevistaEscenarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntrevistaEscenarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre,LstrDescripcion")] EntrevistaEscenario entrevistaEscenario)
        {
            if (ModelState.IsValid)
            {
                db.EntrevistaEscenarios.Add(entrevistaEscenario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entrevistaEscenario);
        }

        // GET: EntrevistaEscenarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaEscenario entrevistaEscenario = db.EntrevistaEscenarios.Find(id);
            if (entrevistaEscenario == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaEscenario);
        }

        // POST: EntrevistaEscenarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre,LstrDescripcion")] EntrevistaEscenario entrevistaEscenario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entrevistaEscenario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entrevistaEscenario);
        }

        // GET: EntrevistaEscenarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntrevistaEscenario entrevistaEscenario = db.EntrevistaEscenarios.Find(id);
            if (entrevistaEscenario == null)
            {
                return HttpNotFound();
            }
            return View(entrevistaEscenario);
        }

        // POST: EntrevistaEscenarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntrevistaEscenario entrevistaEscenario = db.EntrevistaEscenarios.Find(id);
            db.EntrevistaEscenarios.Remove(entrevistaEscenario);
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

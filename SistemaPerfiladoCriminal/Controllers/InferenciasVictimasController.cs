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
    public class InferenciasVictimasController : Controller
    {
        private Contexto db = new Contexto();

        [HttpGet]
        [Route("{id}?")]
        public ActionResult Index(int id)
        {
            return View(db.InferenciaVictimas.ToList());
        }

        // GET: InferenciasVictimas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InferenciaVictima inferenciaVictima = db.InferenciaVictimas.Find(id);
            if (inferenciaVictima == null)
            {
                return HttpNotFound();
            }
            return View(inferenciaVictima);
        }

        // GET: InferenciasVictimas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InferenciasVictimas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrTitulo,LstrDescripcion")] InferenciaVictima inferenciaVictima)
        {
            if (ModelState.IsValid)
            {
                db.InferenciaVictimas.Add(inferenciaVictima);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inferenciaVictima);
        }

        // GET: InferenciasVictimas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InferenciaVictima inferenciaVictima = db.InferenciaVictimas.Find(id);
            if (inferenciaVictima == null)
            {
                return HttpNotFound();
            }
            return View(inferenciaVictima);
        }

        // POST: InferenciasVictimas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrTitulo,LstrDescripcion")] InferenciaVictima inferenciaVictima)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inferenciaVictima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inferenciaVictima);
        }

        // GET: InferenciasVictimas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InferenciaVictima inferenciaVictima = db.InferenciaVictimas.Find(id);
            if (inferenciaVictima == null)
            {
                return HttpNotFound();
            }
            return View(inferenciaVictima);
        }

        // POST: InferenciasVictimas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InferenciaVictima inferenciaVictima = db.InferenciaVictimas.Find(id);
            db.InferenciaVictimas.Remove(inferenciaVictima);
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

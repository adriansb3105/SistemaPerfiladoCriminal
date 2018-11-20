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
    public class CasosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Casos
        public ActionResult Index()
        {
            return View(db.Casos.OrderBy(c => c.LstrNombre).ToList());
        }

        // GET: Casos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }

            List<Victima> victimas = db.Victimas.OrderBy(v => v.LstrNombre).ToList();
            List<Escenario> escenarios = db.Escenarios.OrderBy(e => e.LstrNombre).ToList();
            List<Reconstruccion> reconstrucciones = db.Reconstrucciones.OrderBy(r => r.LstrNombre).ToList();
            List<Autor> autores = db.Autores.OrderBy(a => a.LstrNombre).ToList();

            return View(caso);
        }

        // GET: Casos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Casos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                db.Casos.Add(caso);
                db.SaveChanges();
<<<<<<< HEAD
                return RedirectToAction("/Details/" + caso.LintId);
=======
                return RedirectToAction("/Details/"+caso.LintId);
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
            }

            return View(caso);
        }

        // GET: Casos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // POST: Casos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre")] Caso caso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(caso);
        }

        // GET: Casos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Caso caso = db.Casos.Find(id);
            if (caso == null)
            {
                return HttpNotFound();
            }
            return View(caso);
        }

        // POST: Casos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Caso caso = db.Casos.Find(id);
            db.Casos.Remove(caso);
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

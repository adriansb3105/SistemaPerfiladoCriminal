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
    public class ReconstruccionesController : Controller
    {
        private static int idCaso;
        private Contexto db = new Contexto();

        // GET: Reconstrucciones
        public ActionResult Index()
        {
            return View(db.Reconstrucciones.ToList());
        }

        // GET: Reconstrucciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reconstruccion reconstruccion = db.Reconstrucciones.Find(id);
            if (reconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(reconstruccion);
        }

        [HttpGet]
        [Route("{id}?")]
        public ActionResult Create(int id)
        {
            idCaso = id;
            return View();
        }

        // POST: Reconstrucciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre")] Reconstruccion reconstruccion)
        {
            if (ModelState.IsValid)
            {
                Caso caso = db.Casos.Find(idCaso);

                if (caso != null)
                {
                    caso.LcolReconstrucciones.Add(reconstruccion);
                    reconstruccion.caso = caso;
                    db.Reconstrucciones.Add(reconstruccion);
                    db.SaveChanges();

                    return RedirectToAction("../Casos/Details/" + caso.LintId);
                }
            }

            return View(reconstruccion);
        }

        // GET: Reconstrucciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reconstruccion reconstruccion = db.Reconstrucciones.Find(id);
            if (reconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(reconstruccion);
        }

        // POST: Reconstrucciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre")] Reconstruccion reconstruccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reconstruccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reconstruccion);
        }

        // GET: Reconstrucciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Reconstruccion reconstruccion = db.Reconstrucciones.Find(id);
            if (reconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(reconstruccion);
        }

        // POST: Reconstrucciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Reconstruccion reconstruccion = db.Reconstrucciones.Find(id);
            db.Reconstrucciones.Remove(reconstruccion);
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

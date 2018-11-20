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
    public class CaracteristicasReconstruccionesController : Controller
    {
        private Contexto db = new Contexto();

        // GET: CaracteristicasReconstrucciones
        public ActionResult Index()
        {
            return View(db.CaracteristicasReconstrucciones.ToList());
        }

        // GET: CaracteristicasReconstrucciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaracteristicasReconstruccion caracteristicasReconstruccion = db.CaracteristicasReconstrucciones.Find(id);
            if (caracteristicasReconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicasReconstruccion);
        }

        // GET: CaracteristicasReconstrucciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CaracteristicasReconstrucciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrDetalle")] CaracteristicasReconstruccion caracteristicasReconstruccion)
        {
            if (ModelState.IsValid)
            {
                db.CaracteristicasReconstrucciones.Add(caracteristicasReconstruccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(caracteristicasReconstruccion);
        }

        // GET: CaracteristicasReconstrucciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaracteristicasReconstruccion caracteristicasReconstruccion = db.CaracteristicasReconstrucciones.Find(id);
            if (caracteristicasReconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicasReconstruccion);
        }

        // POST: CaracteristicasReconstrucciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrDetalle")] CaracteristicasReconstruccion caracteristicasReconstruccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(caracteristicasReconstruccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(caracteristicasReconstruccion);
        }

        // GET: CaracteristicasReconstrucciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CaracteristicasReconstruccion caracteristicasReconstruccion = db.CaracteristicasReconstrucciones.Find(id);
            if (caracteristicasReconstruccion == null)
            {
                return HttpNotFound();
            }
            return View(caracteristicasReconstruccion);
        }

        // POST: CaracteristicasReconstrucciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CaracteristicasReconstruccion caracteristicasReconstruccion = db.CaracteristicasReconstrucciones.Find(id);
            db.CaracteristicasReconstrucciones.Remove(caracteristicasReconstruccion);
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

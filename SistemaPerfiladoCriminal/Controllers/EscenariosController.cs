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
    public class EscenariosController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Escenarios
        public ActionResult Index()
        {
            return View(db.Escenarios.ToList());
        }

        // GET: Escenarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escenario escenario = db.Escenarios.Find(id);
            if (escenario == null)
            {
                return HttpNotFound();
            }
            return View(escenario);
        }

        // GET: Escenarios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Escenarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre,LstrDiaHallazgo,LstrFechaHallazgo,LstrHoraHallazgo,LstrUbicacion,LstrSitioHallazgo,LstrCaracteristicasSitio,LstrCondionesAcceso,LstrFrecuenciaPaso,LstrVictimaEncontradaPor,LstrPosicionCuerpo,LstrDescripcionVestimentas,LstrPertenencias,LstrFenomenosCadavericos,LstrDictamenMedicoLegal,LstrCustodiaSitioSuceso,LdtiHoraLevantamientoCuerpo")] Escenario escenario)
        {
            if (ModelState.IsValid)
            {
                db.Escenarios.Add(escenario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(escenario);
        }

        // GET: Escenarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escenario escenario = db.Escenarios.Find(id);
            if (escenario == null)
            {
                return HttpNotFound();
            }
            return View(escenario);
        }

        // POST: Escenarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre,LstrDiaHallazgo,LstrFechaHallazgo,LstrHoraHallazgo,LstrUbicacion,LstrSitioHallazgo,LstrCaracteristicasSitio,LstrCondionesAcceso,LstrFrecuenciaPaso,LstrVictimaEncontradaPor,LstrPosicionCuerpo,LstrDescripcionVestimentas,LstrPertenencias,LstrFenomenosCadavericos,LstrDictamenMedicoLegal,LstrCustodiaSitioSuceso,LdtiHoraLevantamientoCuerpo")] Escenario escenario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escenario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details/" + escenario.LintId);
            }
            return View(escenario);
        }

        // GET: Escenarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escenario escenario = db.Escenarios.Find(id);
            if (escenario == null)
            {
                return HttpNotFound();
            }
            return View(escenario);
        }

        // POST: Escenarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Escenario escenario = db.Escenarios.Find(id);
            db.Escenarios.Remove(escenario);
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

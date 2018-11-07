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
    public class VictimasController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Victimas
        public ActionResult Index()
        {
            return View(db.Victimas.ToList());
        }

        // GET: Victimas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victima victima = db.Victimas.Find(id);
            if (victima == null)
            {
                return HttpNotFound();
            }
            return View(victima);
        }

        // GET: Victimas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Victimas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrFotoURL,LstrNombre,LstrCausa,LstrAlias,LstrSexo,LstrCedula,LdtiFechaNacimiento,LstrNacionalidad,LintEdad,LdblPeso,LdblEstatura,LstrTez,LstrCabello,LstrOjos,LstrMarcasEspeciales,LstrOcupacion,LstrEscolaridad,LstrCreenciaReligiosa,LstrHabitos,LstrPasatiempos,LstrPadecimientos,LstrHistorialMedico,LstrLugarNacimiento,LstrDireccion,LstrTelefono,LstrEstadoConyugal,LstrSalidasPais,LstrExpedienteCriminal,LstrPasadaPor,LstrPrivacionLibertad,LstrInformacionResenia,LstrAutopsia,LstrDictamenToxicologico,LstrLaboratorio,LstrFluidosBiologicos,LstrManeraMuerte,LstrCausaMuerte,LstrLesionesEncontradasAutopsia,LstrToxicologia,LmvMadreVictima,LpvPadreVictima,LmvMatrimonioVictima,LpsvParejaSentimentalVictima,LcolHermanos,LcolHijos")] Victima victima)
        {
            if (ModelState.IsValid)
            {
                db.Victimas.Add(victima);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(victima);
        }

        // GET: Victimas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victima victima = db.Victimas.Find(id);
            if (victima == null)
            {
                return HttpNotFound();
            }
            return View(victima);
        }

        // POST: Victimas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrFotoURL,LstrNombre,LstrCausa,LstrAlias,LstrSexo,LstrCedula,LdtiFechaNacimiento,LstrNacionalidad,LintEdad,LdblPeso,LdblEstatura,LstrTez,LstrCabello,LstrOjos,LstrMarcasEspeciales,LstrOcupacion,LstrEscolaridad,LstrCreenciaReligiosa,LstrHabitos,LstrPasatiempos,LstrPadecimientos,LstrHistorialMedico,LstrLugarNacimiento,LstrDireccion,LstrTelefono,LstrEstadoConyugal,LstrSalidasPais,LstrExpedienteCriminal,LstrPasadaPor,LstrPrivacionLibertad,LstrInformacionResenia,LstrAutopsia,LstrDictamenToxicologico,LstrLaboratorio,LstrFluidosBiologicos,LstrManeraMuerte,LstrCausaMuerte,LstrLesionesEncontradasAutopsia,LstrToxicologia,LmvMadreVictima,LpvPadreVictima,LmvMatrimonioVictima,LpsvParejaSentimentalVictima,LcolHermanos,LcolHijos")] Victima victima)
        {
            if (ModelState.IsValid)
            {
                db.Entry(victima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details/"+victima.LintId);
            }
            return View(victima);
        }

        // GET: Victimas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Victima victima = db.Victimas.Find(id);
            if (victima == null)
            {
                return HttpNotFound();
            }
            return View(victima);
        }

        // POST: Victimas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Victima victima = db.Victimas.Find(id);
            db.Victimas.Remove(victima);
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

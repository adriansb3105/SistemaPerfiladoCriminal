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
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Controllers
{
    public class VictimasController : Controller
    {
        private static int idCaso;
        private Contexto db = new Contexto();
<<<<<<< HEAD

=======
        
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
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

        [HttpGet]
        [Route("{id}?")]
        public ActionResult Create(int id)
        {
            idCaso = id;
            return View();
        }

        // POST: Victimas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrFotoURL,LstrNombre,LstrCausa,LstrAlias,LstrSexo,LstrCedula,LdtiFechaNacimiento,LstrNacionalidad,LintEdad,LdblPeso,LdblEstatura,LstrTez,LstrCabello,LstrOjos,LstrMarcasEspeciales,LstrOcupacion,LstrEscolaridad,LstrCreenciaReligiosa,LstrHabitos,LstrPasatiempos,LstrPadecimientos,LstrHistorialMedico,LstrLugarNacimiento,LstrDireccion,LstrTelefono,LstrEstadoConyugal,LstrSalidasPais,LstrExpedienteCriminal,LstrPasadaPor,LstrPrivacionLibertad,LstrInformacionResenia,LstrAutopsia,LstrDictamenToxicologico,LstrLaboratorio,LstrFluidosBiologicos,LstrManeraMuerte,LstrCausaMuerte,LstrLesionesEncontradasAutopsia,LstrToxicologia,LmvMadreVictima,LpvPadreVictima,LmvMatrimonioVictima,LpsvParejaSentimentalVictima,LcolHermanos,LcolHijos")] Victima victima, HttpPostedFileBase foto)
        {
            if (ModelState.IsValid)
            {
                Caso caso = db.Casos.Find(idCaso);

                if (caso != null)
                {
                    if (foto != null)
                    {
                        victima.LstrFotoURL = new byte[foto.ContentLength];
                        foto.InputStream.Read(victima.LstrFotoURL, 0, foto.ContentLength);
                    }

                    caso.LcolVictimas.Add(victima);
                    victima.caso = caso;
                    db.Victimas.Add(victima);
                    db.SaveChanges();

                    return RedirectToAction("../Casos/Details/" + caso.LintId);
                }
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
        public ActionResult Edit([Bind(Include = "LintId,LstrFotoURL,LstrNombre,LstrCausa,LstrAlias,LstrSexo,LstrCedula,LdtiFechaNacimiento,LstrNacionalidad,LintEdad,LdblPeso,LdblEstatura,LstrTez,LstrCabello,LstrOjos,LstrMarcasEspeciales,LstrOcupacion,LstrEscolaridad,LstrCreenciaReligiosa,LstrHabitos,LstrPasatiempos,LstrPadecimientos,LstrHistorialMedico,LstrLugarNacimiento,LstrDireccion,LstrTelefono,LstrEstadoConyugal,LstrSalidasPais,LstrExpedienteCriminal,LstrPasadaPor,LstrPrivacionLibertad,LstrInformacionResenia,LstrAutopsia,LstrDictamenToxicologico,LstrLaboratorio,LstrFluidosBiologicos,LstrManeraMuerte,LstrCausaMuerte,LstrLesionesEncontradasAutopsia,LstrToxicologia,LmvMadreVictima,LpvPadreVictima,LmvMatrimonioVictima,LpsvParejaSentimentalVictima,LcolHermanos,LcolHijos")] Victima victima, HttpPostedFileBase foto)
        {
            if (ModelState.IsValid)
<<<<<<< HEAD
            {
=======
            {  
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
                if (foto != null)
                {
                    victima.LstrFotoURL = new byte[foto.ContentLength];
                    foto.InputStream.Read(victima.LstrFotoURL, 0, foto.ContentLength);
                }
<<<<<<< HEAD

                db.Entry(victima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details/" + victima.LintId);
=======
                    
                db.Entry(victima).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details/"+victima.LintId);
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
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

        [HttpPost]
        [Route("AgregarInferencias")]
        public JsonResult AgregarInferencias(String inferencia)
        {


            return Json("", JsonRequestBehavior.AllowGet);
        }

    }
}

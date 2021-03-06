﻿using System;
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
    public class AutoresController : Controller
    {
        private static int idCaso;
        private Contexto db = new Contexto();

        // GET: Autores
        public ActionResult Index()
        {
            return View(db.Autores.ToList());
        }
<<<<<<< HEAD

=======
        
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }

            List<DetallesAutor> detalles = db.DetallesAutor.ToList();
<<<<<<< HEAD

=======
            
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
            return View(autor);
        }

        [HttpGet]
        [Route("{id}?")]
        public ActionResult Create(int id)
        {
            idCaso = id;
            return View();
        }

        // POST: Autores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrNombre")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                Caso caso = db.Casos.Find(idCaso);

                if (caso != null)
                {
                    caso.LcolAutores.Add(autor);
                    autor.caso = caso;
                    db.Autores.Add(autor);
                    db.SaveChanges();

                    return RedirectToAction("../Casos/Details/" + caso.LintId);
                }
            }

            return View(autor);
        }

        // GET: Autores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        // POST: Autores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrNombre")] Autor autor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(autor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Details/" + autor.LintId);
            }
            return View(autor);
        }

        // GET: Autores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Autor autor = db.Autores.Find(id);
            if (autor == null)
            {
                return HttpNotFound();
            }
            return View(autor);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Autor autor = db.Autores.Find(id);
            db.Autores.Remove(autor);
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

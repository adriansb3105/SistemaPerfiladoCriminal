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
    public class DetallesAutoresController : Controller
    {
        private int idAutor;
        private Contexto db = new Contexto();

        // GET: DetallesAutores
        public ActionResult Index()
        {
            return View(db.DetallesAutor.ToList());
        }

        // GET: DetallesAutores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        [HttpGet]
        [Route("{id}?")] //Matches GET ComicBooks/Spiderman
        public ActionResult Create(int id)
        {
            /*
            List<SelectListItem> listItems = new List<SelectListItem>();
            List<Autor> autores = db.Autores.ToList();
            foreach (var autor in autores)
            {
                listItems.Add(new SelectListItem
                {
                    Value = autor.LintId.ToString(),
                    Text = autor.LstrNombre
                });
            }
            ViewData["autores"] = listItems;
            */
            this.idAutor = id;
            return View();
        }

        // POST: DetallesAutores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LintId,LstrDetalle,LAutor")] DetallesAutor detallesAutor)
        {
            if (ModelState.IsValid)
            {
                Autor autor = db.Autores.Find(this.idAutor);

                if (autor != null)
                {
                    autor.LcolDetalles.Add(detallesAutor);
                    detallesAutor.LAutor = autor;
                    db.DetallesAutor.Add(detallesAutor);
                    db.SaveChanges();
                }
                return RedirectToAction("../Autores/Details/"+autor.LintId);
            }

            return View(detallesAutor);
        }

        // GET: DetallesAutores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        // POST: DetallesAutores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LintId,LstrDetalle")] DetallesAutor detallesAutor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detallesAutor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detallesAutor);
        }

        // GET: DetallesAutores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            if (detallesAutor == null)
            {
                return HttpNotFound();
            }
            return View(detallesAutor);
        }

        // POST: DetallesAutores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetallesAutor detallesAutor = db.DetallesAutor.Find(id);
            db.DetallesAutor.Remove(detallesAutor);
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

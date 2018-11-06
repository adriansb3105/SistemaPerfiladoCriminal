using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaPerfiladoCriminal.Context;

namespace SistemaPerfiladoCriminal.Controllers
{
    public class AdministradorController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Administrador
        public ActionResult Index()
        {
            return View(db.Casos.ToList());
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaPerfiladoCriminal.Models;
using SistemaPerfiladoCriminal.Context;

namespace SistemaPerfiladoCriminal.Services
{
    public class VictimaRepository
    {
        public List<Victima> ObtenerTodos()
        {
            using (var db = new Contexto())
            {
                return db.Victimas.ToList();
            }
        }

        internal void Crear(Victima model)
        {
            using (var db = new Contexto())
            {
                db.Victimas.Add(model);
                db.SaveChanges();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaPerfiladoCriminal.Models;
using SistemaPerfiladoCriminal.Context;

namespace SistemaPerfiladoCriminal.Services
{
    public class ReconstruccionRepository
    {
        public List<Reconstruccion> ObtenerTodos()
        {
            using (var db = new Contexto())
            {
                return db.Reconstrucciones.ToList();
            }
        }

        internal void Crear(Reconstruccion model)
        {
            using (var db = new Contexto())
            {
                db.Reconstrucciones.Add(model);
                db.SaveChanges();
            }
        }
    }
}
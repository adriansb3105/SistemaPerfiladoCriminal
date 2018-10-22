using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaPerfiladoCriminal.Models;
using SistemaPerfiladoCriminal.Context;

namespace SistemaPerfiladoCriminal.Services
{
    public class AutorRepository
    {
        public List<Autor> Obtener()
        {
            using (var db = new Contexto())
            {
                return db.Autores.ToList();
            }
        }

        internal void Crear(Autor model)
        {
            using (var db = new Contexto())
            {
                db.Autores.Add(model);
                db.SaveChanges();
            }
        }
    }
}
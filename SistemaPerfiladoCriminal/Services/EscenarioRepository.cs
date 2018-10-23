using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SistemaPerfiladoCriminal.Models;
using SistemaPerfiladoCriminal.Context;

namespace SistemaPerfiladoCriminal.Services
{
    public class EscenarioRepository
    {
        public List<Escenario> ObtenerTodos()
        {
            using (var db = new Contexto())
            {
                return db.Escenarios.ToList();
            }
        }

        internal void Crear(Escenario model)
        {
            using (var db = new Contexto())
            {
                db.Escenarios.Add(model);
                db.SaveChanges();
            }
        }
    }
}
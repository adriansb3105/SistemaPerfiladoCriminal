using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SistemaPerfiladoCriminal.Models;

namespace SistemaPerfiladoCriminal.Context
{
    public class Contexto : DbContext
    {
        public Contexto() : base("DefaultConnection")
        {
            //enable-migrations -Force
            //update-database -Verbose
        }

        public DbSet<Autor> Autores { get; set;  }
    }
}
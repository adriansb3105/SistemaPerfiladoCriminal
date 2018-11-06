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

        public DbSet<Autor> Autores { get; set; }
        public DbSet<CaracteristicasReconstruccion> CaracteristicasReconstrucciones { get; set; }
        public DbSet<Caso> Casos { get; set; }
        public DbSet<DetallesAutor> DetallesAutor { get; set; }
        public DbSet<EntrevistaEscenario> EntrevistaEscenarios { get; set; }
        public DbSet<EntrevistaVictima> EntrevistaVictimas { get; set; }
        public DbSet<Escenario> Escenarios { get; set; }
        
        public DbSet<Reconstruccion> Reconstrucciones { get; set; }
        public DbSet<Victima> Victimas { get; set; }


        /*protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // configures one-to-many relationship
            modelBuilder.Entity<Detalle>()
                .HasRequired<Autor>(s => s.LAutor)
                .WithMany(g => g.LcolDetalles)
                .HasForeignKey<int>(s => s.LintAutorId);

            modelBuilder.Entity<Detalle>()
                .HasRequired<Reconstruccion>(s => s.LReconstruccion)
                .WithMany(g => g.LcolDetalles)
                .HasForeignKey<int>(s => s.LintReconstruccionId);
        }*/
    }
}
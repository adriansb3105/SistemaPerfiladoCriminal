namespace SistemaPerfiladoCriminal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SistemaPerfiladoCriminal.Context.Contexto>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SistemaPerfiladoCriminal.Context.Contexto context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            /*context.Comentarios.AddOrUpdate(x => x.Id, new Comentario()
            {
                Id = 1,
                Autor = "Pablo",
                BlogPostId = 1,
                Contenido = "Ejemplo de contenido"
            });*/
        }
    }
}

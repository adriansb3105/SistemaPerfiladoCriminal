using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SistemaPerfiladoCriminal.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Victima> Victimas { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Reconstruccion> Reconstruccions { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.InferenciaVictima> InferenciaVictimas { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Indicio> Indicios { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Escenario> Escenarios { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.EntrevistaVictima> EntrevistaVictimas { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.EntrevistaEscenario> EntrevistaEscenarios { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.DetallesAutor> DetallesAutors { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Caso> Casoes { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.CaracteristicasReconstruccion> CaracteristicasReconstruccions { get; set; }

        public System.Data.Entity.DbSet<SistemaPerfiladoCriminal.Models.Autor> Autors { get; set; }
    }
}
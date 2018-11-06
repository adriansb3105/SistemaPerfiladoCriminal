using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("MadresVictima")]
    public class MadreVictima : Persona
    {
        public Persona persona;
        public String LstrTelefono { get; set; }

        public MadreVictima()
        {
        }

        public MadreVictima(string lstrTelefono, String lstrNombre) : base(lstrNombre)
        {
            this.persona = new Persona(lstrNombre);
            LstrTelefono = lstrTelefono;
        }
    }
}

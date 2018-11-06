using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("HermanosVictima")]
    public class HermanoVictima : Persona
    {
        public Persona persona;
        public String LstrTelefono { get; set; }

        public HermanoVictima()
        {
        }

        public HermanoVictima(string lstrTelefono, String lstrNombre) : base(lstrNombre)
        {
            this.persona = new Persona(lstrNombre);
            LstrTelefono = lstrTelefono;
        }
    }
}

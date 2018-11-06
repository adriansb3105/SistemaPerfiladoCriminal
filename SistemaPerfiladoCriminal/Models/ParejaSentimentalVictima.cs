using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("ParejaSentimentalesVictima")]
    public class ParejaSentimentalVictima : Persona
    {
        public Persona persona;
        public String LstrCedula { get; set; }
        public String LstrAlias { get; set; }
        public String LstrTelefono { get; set; }

        public ParejaSentimentalVictima()
        {
        }

        public ParejaSentimentalVictima(string lstrCedula, string lstrAlias, string lstrTelefono, String lstrNombre) : base(lstrNombre)
        {
            this.persona = new Persona(lstrNombre);
            LstrCedula = lstrCedula;
            LstrAlias = lstrAlias;
            LstrTelefono = lstrTelefono;
        }
    }
}

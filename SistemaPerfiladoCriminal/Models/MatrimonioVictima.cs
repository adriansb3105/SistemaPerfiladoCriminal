using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("MatrimoniosVictima")]
    public class MatrimonioVictima : Persona
    {
        public Persona persona;
        public String LstrCedula { get; set; }
        public String LstrNacionalidad { get; set; }
        public DateTime LstrFecha { get; set; }

        public MatrimonioVictima()
        {
        }

        public MatrimonioVictima(string lstrCedula, string lstrNacionalidad, DateTime lstrFecha, String lstrNombre) : base(lstrNombre)
        {
            this.persona = new Persona(lstrNombre);
            LstrCedula = lstrCedula;
            LstrNacionalidad = lstrNacionalidad;
            LstrFecha = lstrFecha;
        }
    }
}

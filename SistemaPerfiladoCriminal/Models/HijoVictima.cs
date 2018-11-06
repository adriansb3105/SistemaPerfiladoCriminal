using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("HijosVictima")]
    public class HijoVictima : Persona
    {
        public Persona persona;
        public String LstrCedula { get; set; }
        public String LstrNacionalidad { get; set; }
        public int LintEdad { get; set; }
        public String LstrTelefono { get; set; }

        public HijoVictima()
        {
        }

        public HijoVictima(string lstrCedula, string lstrNacionalidad, int lintEdad, string lstrTelefono, String lstrNombre) : base(lstrNombre)
        {
            this.persona = new Persona(lstrNombre);
            LstrCedula = lstrCedula;
            LstrNacionalidad = lstrNacionalidad;
            LintEdad = lintEdad;
            LstrTelefono = lstrTelefono;
        }
    }
}

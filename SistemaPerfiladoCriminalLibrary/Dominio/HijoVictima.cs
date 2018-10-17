using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class HijoVictima
    {
        private int lintId;
        private String lstrNombre;
        private String lstrCedula;
        private String lstrNacionalidad;
        private int lintEdad;
        private String lstrTelefono;

        public int LintId { get => lintId; set => lintId = value; }
        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrCedula { get => lstrCedula; set => lstrCedula = value; }
        public string LstrNacionalidad { get => lstrNacionalidad; set => lstrNacionalidad = value; }
        public int LintEdad { get => lintEdad; set => lintEdad = value; }
        public string LstrTelefono { get => lstrTelefono; set => lstrTelefono = value; }
    }
}

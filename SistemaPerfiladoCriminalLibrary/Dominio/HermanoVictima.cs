using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class HermanoVictima
    {
        private int lintId;
        private String lstrNombre;
        private String lstrTelefono;

        public int LintId { get => lintId; set => lintId = value; }
        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrTelefono { get => lstrTelefono; set => lstrTelefono = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class PadreVictima
    {
        private String lstrNombre;
        private String lstrTelefono;

        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrTelefono { get => lstrTelefono; set => lstrTelefono = value; }
    }
}

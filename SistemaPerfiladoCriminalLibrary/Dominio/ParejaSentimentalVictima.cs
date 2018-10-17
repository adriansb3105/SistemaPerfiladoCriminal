using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class ParejaSentimentalVictima
    {
        private String lstrNombre;
        private String lstrCedula;
        private String lstrAlias;
        private String lstrTelefono;

        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrCedula { get => lstrCedula; set => lstrCedula = value; }
        public string LstrAlias { get => lstrAlias; set => lstrAlias = value; }
        public string LstrTelefono { get => lstrTelefono; set => lstrTelefono = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class Entrevista
    {
        private int lstrId;
        private String lstrNombre;
        private String lstrDescripcion;

        public int LstrId { get => lstrId; set => lstrId = value; }
        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrDescripcion { get => lstrDescripcion; set => lstrDescripcion = value; }
    }
}

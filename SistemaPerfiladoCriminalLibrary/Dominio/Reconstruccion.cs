using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class Reconstruccion
    {
        private int lstrId;
        private ICollection<String> lcolDetalles;

        public int LstrId { get => lstrId; set => lstrId = value; }
        public ICollection<string> LcolDetalles { get => lcolDetalles; set => lcolDetalles = value; }
    }
}

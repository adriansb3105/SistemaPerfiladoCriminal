using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class MatrimonioVictima
    {
        private String lstrNombre;
        private String lstrCedula;
        private String lstrNacionalidad;
        private DateTime lstrFecha;

        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrCedula { get => lstrCedula; set => lstrCedula = value; }
        public string LstrNacionalidad { get => lstrNacionalidad; set => lstrNacionalidad = value; }
        public DateTime LstrFecha { get => lstrFecha; set => lstrFecha = value; }
    }
}

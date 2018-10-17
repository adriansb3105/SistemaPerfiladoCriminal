using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class Escenario
    {
        private int lstrId;
        private String lstrDiaHallazgo;
        private DateTime lstrFechaHallazgo;
        private String lstrHoraHallazgo;
        private String lstrUbicacion;
        private String lstrSitioHallazgo;
        private String lstrCaracteristicasSitio;
        private String lstrCondionesAcceso;
        private String lstrFrecuenciaPaso;
        private String lstrVictimaEncontradaPor;
        private String lstrPosicionCuerpo;
        private String lstrDescripcionVestimentas;
        private String lstrPertenencias;
        private String lstrFenomenosCadavericos;
        private String lstrDictamenMedicoLegal;
        private String lstrCustodiaSitioSuceso;
        private DateTime ldtiHoraLevantamientoCuerpo;
        private ICollection<Indicio> lcolIndicios;
        private ICollection<Entrevista> lcolEntrevistas;
    }
}

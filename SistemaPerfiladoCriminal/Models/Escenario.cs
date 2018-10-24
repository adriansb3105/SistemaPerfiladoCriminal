using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    public class Escenario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrDiaHallazgo { get; set; }
        public DateTime LstrFechaHallazgo { get; set; }
        public String LstrHoraHallazgo { get; set; }
        public String LstrUbicacion { get; set; }
        public String LstrSitioHallazgo { get; set; }
        public String LstrCaracteristicasSitio { get; set; }
        public String LstrCondionesAcceso { get; set; }
        public String LstrFrecuenciaPaso { get; set; }
        public String LstrVictimaEncontradaPor { get; set; }
        public String LstrPosicionCuerpo { get; set; }
        public String LstrDescripcionVestimentas { get; set; }
        public String LstrPertenencias { get; set; }
        public String LstrFenomenosCadavericos { get; set; }
        public String LstrDictamenMedicoLegal { get; set; }
        public String LstrCustodiaSitioSuceso { get; set; }
        public DateTime LdtiHoraLevantamientoCuerpo { get; set; }
        public ICollection<Indicio> LcolIndicios { get; set; }
        public ICollection<EntrevistaEscenario> LcolEntrevistas { get; set; }
    }
}

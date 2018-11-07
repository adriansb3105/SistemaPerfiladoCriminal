using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Victimas")]
    public class Victima
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrFotoURL { get; set; }
        public String LstrNombre { get; set; }
        public String LstrCausa { get; set; }
        public String LstrAlias { get; set; }
        public String LstrSexo { get; set; }
        public String LstrCedula { get; set; }
        public DateTime LdtiFechaNacimiento { get; set; }
        public String LstrNacionalidad { get; set; }
        public int LintEdad { get; set; }
        public double LdblPeso { get; set; }
        public double LdblEstatura { get; set; }
        public String LstrTez { get; set; }
        public String LstrCabello { get; set; }
        public String LstrOjos { get; set; }
        public String LstrMarcasEspeciales { get; set; }
        public String LstrOcupacion { get; set; }
        public String LstrEscolaridad { get; set; }
        public String LstrCreenciaReligiosa { get; set; }
        public String LstrHabitos { get; set; }
        public String LstrPasatiempos { get; set; }
        public String LstrPadecimientos { get; set; }
        public String LstrHistorialMedico { get; set; }
        public String LstrLugarNacimiento { get; set; }
        public String LstrDireccion { get; set; }
        public String LstrTelefono { get; set; }
        public String LstrEstadoConyugal { get; set; }
        public String LstrSalidasPais { get; set; }
        public String LstrExpedienteCriminal { get; set; }
        public String LstrPasadaPor { get; set; }
        public String LstrPrivacionLibertad { get; set; }
        public String LstrInformacionResenia { get; set; }
        public String LstrAutopsia { get; set; }
        public String LstrDictamenToxicologico { get; set; }
        public String LstrLaboratorio { get; set; }
        public String LstrFluidosBiologicos { get; set; }
        public String LstrManeraMuerte { get; set; }
        public String LstrCausaMuerte { get; set; }
        public String LstrLesionesEncontradasAutopsia { get; set; }
        public String LstrToxicologia { get; set; }
        public String LmvMadreVictima { get; set; }
        public String LpvPadreVictima { get; set; }
        public String LmvMatrimonioVictima { get; set; }
        public String LpsvParejaSentimentalVictima { get; set; }
        public String LcolHermanos { get; set; }
        public String LcolHijos { get; set; }
        public List<EntrevistaVictima> LcolEntrevistas { get; set; }
        public Caso caso;

        public Victima()
        {
            this.LcolEntrevistas = new List<EntrevistaVictima>();
            this.caso = new Caso();
        }
    }
}
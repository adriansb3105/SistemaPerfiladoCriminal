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

        [DataType(DataType.ImageUrl, ErrorMessage = "Debe ingresar una imagen")]
        public byte[] LstrFotoURL { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrNombre { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrCausa { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrAlias { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrSexo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrCedula { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [DataType(DataType.Date, ErrorMessage = "Debe ingresar la fecha de nacimiento")]
        public DateTime LdtiFechaNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrNacionalidad { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Debe ingresar un valor numérico")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Debe ingresar un valor numérico")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public int LintEdad { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Debe ingresar un valor numérico")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public double LdblPeso { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Debe ingresar un valor numérico")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public double LdblEstatura { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrTez { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrCabello { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrOjos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrMarcasEspeciales { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrOcupacion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrEscolaridad { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrCreenciaReligiosa { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrHabitos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrPasatiempos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrPadecimientos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrHistorialMedico { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrLugarNacimiento { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrDireccion { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrTelefono { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrEstadoConyugal { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrSalidasPais { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrExpedienteCriminal { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrPasadaPor { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrPrivacionLibertad { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrInformacionResenia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrAutopsia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrDictamenToxicologico { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrLaboratorio { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrFluidosBiologicos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrManeraMuerte { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrCausaMuerte { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrLesionesEncontradasAutopsia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrToxicologia { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LmvMadreVictima { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LpvPadreVictima { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LmvMatrimonioVictima { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LpsvParejaSentimentalVictima { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LcolHermanos { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LcolHijos { get; set; }

        public virtual List<EntrevistaVictima> LcolEntrevistas { get; set; }

        public Caso caso;

        public Victima()
        {
            this.LcolEntrevistas = new List<EntrevistaVictima>();
            this.caso = new Caso();
        }
    }
}
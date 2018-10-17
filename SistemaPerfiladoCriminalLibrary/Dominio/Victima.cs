using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminalLibrary.Dominio
{
    public class Victima
    {
        private int lstrId;
        private String lstrFotoURL;
        private String lstrNombre;
        private String lstrCausa;
        private String lstrAlias;
        private String lstrSexo;
        private String lstrCedula;
        private DateTime ldtiFechaNacimiento;
        private String lstrNacionalidad;
        private int lintEdad;
        private double ldblPeso;
        private double ldblEstatura;
        private String lstrTez;
        private String lstrCabello;
        private String lstrOjos;
        private String lstrMarcasEspeciales;
        private String lstrOcupacion;
        private String lstrEscolaridad;
        private String lstrCreenciaReligiosa;
        private String lstrHabitos;
        private String lstrPasatiempos;
        private String lstrPadecimientos;
        private String lstrHistorialMedico;
        private String lstrLugarNacimiento;
        private String lstrDireccion;
        private String lstrTelefono;
        private String lstrEstadoConyugal;
        private String lstrSalidasPais;
        private String lstrExpedienteCriminal;
        private String lstrPasadaPor;
        private String lstrPrivacionLibertad;
        private String lstrInformacionResenia;
        private String lstrAutopsia;
        private String lstrDictamenToxicologico;
        private String lstrLaboratorio;
        private String lstrFuidosBiologicos;
        private String lstrManeraMuerte;
        private String lstrCausaMuerte;
        private String lstrLesionesEncontradasAutopsia;
        private String lstrToxicologia;
        private MadreVictima madreVictima;
        private PadreVictima padreVictima;
        private MatrimonioVictima matrimonioVictima;
        private ParejaSentimentalVictima parejaSentimentalVictima;
        private ICollection<HermanoVictima> lcolHermanos;
        private ICollection<HijoVictima> lcolHijos;
        private ICollection<Entrevista> lcolEntrevistas;

        public int LstrId { get => lstrId; set => lstrId = value; }
        public string LstrFotoURL { get => lstrFotoURL; set => lstrFotoURL = value; }
        public string LstrNombre { get => lstrNombre; set => lstrNombre = value; }
        public string LstrCausa { get => lstrCausa; set => lstrCausa = value; }
        public string LstrAlias { get => lstrAlias; set => lstrAlias = value; }
        public string LstrSexo { get => lstrSexo; set => lstrSexo = value; }
        public string LstrCedula { get => lstrCedula; set => lstrCedula = value; }
        public DateTime LdtiFechaNacimiento { get => ldtiFechaNacimiento; set => ldtiFechaNacimiento = value; }
        public string LstrNacionalidad { get => LstrNacionalidad1; set => LstrNacionalidad1 = value; }
        public string LstrNacionalidad1 { get => lstrNacionalidad; set => lstrNacionalidad = value; }
        public int LintEdad { get => lintEdad; set => lintEdad = value; }
        public double LdblPeso { get => ldblPeso; set => ldblPeso = value; }
        public double LdblEstatura { get => ldblEstatura; set => ldblEstatura = value; }
        public string LstrTez { get => lstrTez; set => lstrTez = value; }
        public string LstrCabello { get => lstrCabello; set => lstrCabello = value; }
        public string LstrOjos { get => lstrOjos; set => lstrOjos = value; }
        public string LstrMarcasEspeciales { get => lstrMarcasEspeciales; set => lstrMarcasEspeciales = value; }
        public string LstrOcupacion { get => lstrOcupacion; set => lstrOcupacion = value; }
        public string LstrEscolaridad { get => lstrEscolaridad; set => lstrEscolaridad = value; }
        public string LstrCreenciaReligiosa { get => lstrCreenciaReligiosa; set => lstrCreenciaReligiosa = value; }
        public string LstrHabitos { get => lstrHabitos; set => lstrHabitos = value; }
        public string LstrPasatiempos { get => lstrPasatiempos; set => lstrPasatiempos = value; }
        public string LstrPadecimientos { get => lstrPadecimientos; set => lstrPadecimientos = value; }
        public string LstrHistorialMedico { get => lstrHistorialMedico; set => lstrHistorialMedico = value; }
        public string LstrLugarNacimiento { get => lstrLugarNacimiento; set => lstrLugarNacimiento = value; }
        public string LstrDireccion { get => lstrDireccion; set => lstrDireccion = value; }
        public string LstrTelefono { get => lstrTelefono; set => lstrTelefono = value; }
        public ICollection<HermanoVictima> LcolHermanos { get => lcolHermanos; set => lcolHermanos = value; }
        public ICollection<HijoVictima> LcolHijos { get => lcolHijos; set => lcolHijos = value; }
        public string LstrEstadoConyugal { get => lstrEstadoConyugal; set => lstrEstadoConyugal = value; }
        public MadreVictima MadreVictima { get => madreVictima; set => madreVictima = value; }
        public PadreVictima PadreVictima { get => padreVictima; set => padreVictima = value; }
        public MatrimonioVictima MatrimonioVictima { get => matrimonioVictima; set => matrimonioVictima = value; }
        public ParejaSentimentalVictima ParejaSentimentalVictima { get => parejaSentimentalVictima; set => parejaSentimentalVictima = value; }
        public string LstrSalidasPais { get => lstrSalidasPais; set => lstrSalidasPais = value; }
        public string LstrExpedienteCriminal { get => lstrExpedienteCriminal; set => lstrExpedienteCriminal = value; }
        public string LstrPasadaPor { get => lstrPasadaPor; set => lstrPasadaPor = value; }
        public string LstrPrivacionLibertad { get => lstrPrivacionLibertad; set => lstrPrivacionLibertad = value; }
        public string LstrInformacionResenia { get => lstrInformacionResenia; set => lstrInformacionResenia = value; }
        public string LstrAutopsia { get => lstrAutopsia; set => lstrAutopsia = value; }
        public string LstrDictamenToxicologico { get => lstrDictamenToxicologico; set => lstrDictamenToxicologico = value; }
        public string LstrLaboratorio { get => lstrLaboratorio; set => lstrLaboratorio = value; }
        public string LstrFuidosBiologicos { get => lstrFuidosBiologicos; set => lstrFuidosBiologicos = value; }
        public string LstrManeraMuerte { get => lstrManeraMuerte; set => lstrManeraMuerte = value; }
        public string LstrCausaMuerte { get => lstrCausaMuerte; set => lstrCausaMuerte = value; }
        public string LstrLesionesEncontradasAutopsia { get => lstrLesionesEncontradasAutopsia; set => lstrLesionesEncontradasAutopsia = value; }
        public string LstrToxicologia { get => lstrToxicologia; set => lstrToxicologia = value; }
        public ICollection<Entrevista> LcolEntrevistas { get => lcolEntrevistas; set => lcolEntrevistas = value; }
    }
}

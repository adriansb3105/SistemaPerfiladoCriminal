using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("InferenciasVictimas")]
    public class InferenciaVictima
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrTitulo { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        public String LstrDescripcion { get; set; }

        public virtual List<String> LcolDatos { get; set; }

        public InferenciaVictima()
        {
        }

        public InferenciaVictima(string lstrTitulo, string lstrDescripcion)
        {
            LstrTitulo = lstrTitulo;
            LstrDescripcion = lstrDescripcion;
            LcolDatos = new List<string>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Reconstrucciones")]
    public class Reconstruccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrNombre { get; set; }
        public virtual List<CaracteristicasReconstruccion> LcolCaracteristicas { get; set; }
        public Caso caso;

        public Reconstruccion()
        {
            this.LcolCaracteristicas = new List<CaracteristicasReconstruccion>();
            this.caso = new Caso();
        }
    }
}

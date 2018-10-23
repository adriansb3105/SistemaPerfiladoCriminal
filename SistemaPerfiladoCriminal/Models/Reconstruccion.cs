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
        public int LintId { get; set; }
        public int LstrId { get; set; }
        public ICollection<Detalle> LcolDetalles;
    }
}

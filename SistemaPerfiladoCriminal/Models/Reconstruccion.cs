using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    public class Reconstruccion
    {
        [Key]
        public int LintId { get; set; }
        public int LstrId { get; set; }
        public ICollection<Detalle> LcolDetalles;
    }
}

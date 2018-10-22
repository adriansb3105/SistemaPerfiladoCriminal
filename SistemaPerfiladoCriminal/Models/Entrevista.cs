using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    public class Entrevista
    {
        [Key]
        public int LstrId { get; set; }
        public String LstrNombre { get; set; }
        public String LstrDescripcion { get; set; }
    }
}

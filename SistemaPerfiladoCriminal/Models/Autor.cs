using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    public class Autor
    {
        [Key]
        public int LstrId { get; set; }
        public ICollection<String> LcolDetalles { get; set; }
    }
}

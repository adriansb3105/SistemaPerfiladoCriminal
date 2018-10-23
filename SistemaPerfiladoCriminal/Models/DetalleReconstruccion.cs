using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("DetallesReconstruccion")]
    public class DetalleReconstruccion
    {
        [Key]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }
    }
}

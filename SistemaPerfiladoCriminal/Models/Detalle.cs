using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    public class Detalle
    {
        [Key]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }
    }
}
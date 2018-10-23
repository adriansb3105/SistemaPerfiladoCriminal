using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("DetallesAutor")]
    public class DetalleAutor
    {
        [Key]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }
    }
}
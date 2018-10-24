using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    public class EntrevistaVictima
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrNombre { get; set; }
        public String LstrDescripcion { get; set; }
    }
}
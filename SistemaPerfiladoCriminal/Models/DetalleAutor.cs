using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaPerfiladoCriminal.Models
{
    [Table("DetallesAutor")]
    public class DetalleAutor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }
    }
}
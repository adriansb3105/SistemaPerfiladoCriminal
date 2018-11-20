using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Indicios")]
    public class Indicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrDescripcion { get; set; }

        public Indicio()
        {
        }

        public Indicio(string lstrDescripcion)
        {
            this.LstrDescripcion = lstrDescripcion;
        }
    }
}

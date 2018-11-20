using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Autores")]
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrNombre { get; set; }
        public virtual List<DetallesAutor> LcolDetalles { get; set; }
        public Caso caso;

        public Autor()
        {
            this.LcolDetalles = new List<DetallesAutor>();
            this.caso = new Caso();
        }
    }
}

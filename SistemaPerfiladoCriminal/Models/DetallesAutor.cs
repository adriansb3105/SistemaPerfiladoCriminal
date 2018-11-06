using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("DetallesAutores")]
    public class DetallesAutor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }
        
        public Autor LAutor { get; set; }
        
        public DetallesAutor()
        {
        }

        public DetallesAutor(string lstrDetalle)
        {
            this.LstrDetalle = lstrDetalle;
        }
    }
}
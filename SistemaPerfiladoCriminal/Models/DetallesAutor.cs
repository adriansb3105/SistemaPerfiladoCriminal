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
<<<<<<< HEAD

        public Autor LAutor { get; set; }

=======
        
        public Autor LAutor { get; set; }
        
>>>>>>> 5778c7425840c6f79de49cd3cd2a7f97a9bca9b3
        public DetallesAutor()
        {
        }

        public DetallesAutor(string lstrDetalle)
        {
            this.LstrDetalle = lstrDetalle;
        }
    }
}
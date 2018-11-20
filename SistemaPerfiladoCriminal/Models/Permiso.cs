using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }

        public string LstrNombre { get; set; }

        public Permiso(string nombre)
        {
            this.LstrNombre = nombre;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Roles")]
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }

        public string LstrNombre { get; set; }

        public virtual List<Permiso> LcolPermisos { get; set; }

        public Rol(string nombre, List<Permiso> permisos)
        {
            this.LstrNombre = nombre;
            this.LcolPermisos = permisos;
        }
    }
}
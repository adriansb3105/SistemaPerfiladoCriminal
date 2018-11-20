using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }

        public string LstrNombre { get; set; }
        public string LstrUsuario { get; set; }
        public string LstrContrasenia { get; set; }

        public Rol LrlRol { get; set; }

        public Usuario()
        {
        }

        public Usuario(string nombre, string usuario, string contrasenia, Rol rol)
        {
            this.LstrNombre = nombre;
            this.LstrUsuario = usuario;
            this.LstrContrasenia = contrasenia;
            this.LrlRol = rol;
        }
    }
}
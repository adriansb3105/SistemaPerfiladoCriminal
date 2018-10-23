﻿using System;
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
        public int LstrId { get; set; }
        public ICollection<DetalleAutor> LcolDetallesAutor { get; set; }
    }
}

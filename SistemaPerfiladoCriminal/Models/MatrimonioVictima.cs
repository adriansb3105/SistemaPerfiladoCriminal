﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPerfiladoCriminal.Models
{
    public class MatrimonioVictima
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrNombre { get; set; }
        public String LstrCedula { get; set; }
        public String LstrNacionalidad { get; set; }
        public DateTime LstrFecha { get; set; }
    }
}

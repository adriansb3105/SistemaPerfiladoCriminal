using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("CaracteristicasReconstrucciones")]
    public class CaracteristicasReconstruccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrDetalle { get; set; }

        public Reconstruccion LReconstruccion { get; set; }

        public CaracteristicasReconstruccion()
        {
        }

        public CaracteristicasReconstruccion(string lstrDetalle)
        {
            this.LstrDetalle = lstrDetalle;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaPerfiladoCriminal.Models
{
    [Table("Casos")]
    public class Caso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LintId { get; set; }
        public String LstrNombre { get; set; }
        public virtual List<Victima> LcolVictimas { get; set; }
        public virtual List<Escenario> LcolEscenarios { get; set; }
        public virtual List<Reconstruccion> LcolReconstrucciones { get; set; }
        public virtual List<Autor> LcolAutores { get; set; }

        public Caso()
        {
            this.LcolVictimas = new List<Victima>();
            this.LcolEscenarios = new List<Escenario>();
            this.LcolReconstrucciones = new List<Reconstruccion>();
            this.LcolAutores = new List<Autor>();
        }
    }
}
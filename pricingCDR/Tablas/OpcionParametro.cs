using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pricingCDR.Tablas
{
    public class OpcionParametro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdOpcionParametro { get; set; }
        [ForeignKey("Parametro")]
        public int IdParametro { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }

        public virtual Parametro Parametro { get; set; }
    }
}

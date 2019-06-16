using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pricingCDR.Tablas
{
    public class ParametroAdicional
    {
        [Key]
        public int IdParametroAdicional { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }

        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}

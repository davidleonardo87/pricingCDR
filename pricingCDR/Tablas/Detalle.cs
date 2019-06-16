using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pricingCDR.Tablas
{
    public class Detalle
    {
        [Key]
        public int IdDetalle { get; set; }
        public TipoServicio TipoServicio { get; set; }
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        [ForeignKey("Servicio")]
        public int IdServicio { get; set; }
        public decimal Costo { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Servicio Servicio { get; set; }

        public virtual ICollection<ParametroAdicional> ParametrosAdicionales { get; set; }

    }
}

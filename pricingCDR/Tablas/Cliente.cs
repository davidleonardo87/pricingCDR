using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pricingCDR.Tablas
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Numero { get; set; }

        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}

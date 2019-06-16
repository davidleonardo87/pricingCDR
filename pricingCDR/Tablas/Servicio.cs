using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricingCDR.Tablas
{
    public class Servicio
    {
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public byte Orden { get; set; }
    }
}

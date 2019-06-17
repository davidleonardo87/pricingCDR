using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pricingCDR.Tablas
{
    public class Parametro
    {
        [Key]
        public int IdParametro { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
        public TipoServicio TipoServicio { get; set; }
        public byte Orden { get; set; }
        public string Valor { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public TipoParametro TipoParametro { get; set; }
        public bool TieneOpciones { get; set; }

        public ICollection<Servicio> Servicios { get; set; }
        public virtual ICollection<OpcionParametro> OpcionesParametro { get; set; }

        #region NotMappedProperties
        [NotMapped]
        public bool Check { get; set; }
        [NotMapped]
        public object NuevoValor { get; set; }
        #endregion

        public Parametro()
        {
            Servicios = new List<Servicio>();
            OpcionesParametro = new List<OpcionParametro>();
            NuevoValor = null;
        }

    }
}

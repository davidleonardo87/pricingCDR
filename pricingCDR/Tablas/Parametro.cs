﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

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

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pricingCDR
{
    public abstract class ValoresGlobales
    {
        public static class Reportes
        {
            public const string OnTime = "pricingCDR.Reportes.RptOnTime.rdlc";
            public const string OffLine = "pricingCDR.Reportes.RptOffLine.rdlc";
            public static class DataSourceNames
            {
                public const string OnTime = "OnTimeDataSet";
            }
        }
    }
}

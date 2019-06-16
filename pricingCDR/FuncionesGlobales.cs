using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace pricingCDR
{
    public abstract class FuncionesGlobales
    {
        /// <summary>
        /// Insert records to the database
        /// </summary>
        public static void Seed()
        {
            using (Datos.ModelCDR context = new Datos.ModelCDR())
            {
                // agregar servicios
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 1,
                        Descripcion = "Internet 3G",
                        Estado = "A",
                        Orden = 1,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 2,
                        Descripcion = "Internet 4G",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 3,
                        Descripcion = "Televisión por cable",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });

                //save
                context.SaveChanges();
            }
        }

        //public static void CrearBase()
        //{
        //    string path = ConfigurationManager.AppSettings["pathdb"].ToString();
        //    bool exists = Directory.Exists(path);
        //    if (!exists)
        //    {
        //        Directory.CreateDirectory(path);
        //    }
        //    string file = ConfigurationManager.AppSettings["filedb"].ToString();
        //    string realfilename = "";
        //    if (!path[path.Length-1].ToString().Contains(@"\"))
        //    {
        //        realfilename = (path + @"\"+ file);
        //    }
        //    else
        //    {
        //        realfilename = (path + file);
        //    }
        //    bool existsfile = File.Exists(realfilename);
        //    if (!existsfile)
        //    {
                
        //        CrearEstructura();
        //    }
        //}

        //private static void CrearEstructura()
        //{

        //}

    }
}

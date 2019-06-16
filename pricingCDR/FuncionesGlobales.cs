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
                // add servicios
                #region add servicios
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 1,
                        Descripcion = "Internet 3G Familia",
                        Estado = "A",
                        Orden = 1,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 2,
                        Descripcion = "Internet 4G Empresa",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 3,
                        Descripcion = "Paquete Llamadas",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OnTime
                    });
                //save servicios
                context.SaveChanges();
                #endregion

                // agregar Clientes
                #region add clientes
                context.Clientes.Add(
                    new Tablas.Cliente() {
                        Estado = "A",
                        IdCliente = 1,
                        Nombre = "Dr. Carlos Alvarado",
                        Numero = "0982547821"
                    });
                context.Clientes.Add(
                    new Tablas.Cliente()
                    {
                        Estado = "A",
                        IdCliente = 2,
                        Nombre = "Ing. Andrea Rivera",
                        Numero = "0987458745"
                    });
                context.Clientes.Add(
                    new Tablas.Cliente()
                    {
                        Estado = "A",
                        IdCliente = 3,
                        Nombre = "Leonardo Rood",
                        Numero = "0987254785"
                    });
                context.Clientes.Add(
                    new Tablas.Cliente()
                    {
                        Estado = "A",
                        IdCliente = 4,
                        Nombre = "David Gonzalez",
                        Numero = "0978548236"
                    });
                //save clientes
                context.SaveChanges();
                #endregion

                //agregar parametros
                #region add parametro
                context.Parametros.Add(
                    new Tablas.Parametro()
                    {
                        IdParametro = 1,
                        Descripcion = "Segundos",
                        Estado = "A",
                        Orden = 1,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Valor = "0.017",
                        Cantidad = 0
                    });
                context.Parametros.Add(
                    new Tablas.Parametro()
                    {
                        IdParametro = 2,
                        Descripcion = "Días",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Valor = "0.71",
                        Cantidad = 0
                    });
                context.Parametros.Add(
                    new Tablas.Parametro()
                    {
                        IdParametro = 3,
                        Descripcion = "Región",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Valor = "Costa",
                        Cantidad = 0
                    });
                context.SaveChanges();
                #endregion

                //agregar servicios offline
                #region add serviciosOffLine
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 4,
                        Descripcion = "Paquete Internet 3G Mensual",
                        Estado = "A",
                        Orden = 4,
                        TipoServicio = Tablas.TipoServicio.OffLine
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 5,
                        Descripcion = "Paquete Internet 4G Diario",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OffLine
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 6,
                        Descripcion = "Telefonía Ilimitada",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OffLine
                    });
                //save servicios offline
                context.SaveChanges();
                #endregion
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

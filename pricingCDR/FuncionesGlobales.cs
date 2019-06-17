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

                //agregar parametros
                #region add parametro
                var parametrouno = new Tablas.Parametro()
                {
                    IdParametro = 1,
                    Descripcion = "Mensualidad",
                    Estado = "A",
                    Orden = 1,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Valor = "22.00",
                    Costo = 22.00m,
                    TipoParametro = Tablas.TipoParametro.ValorPorUnidad,
                    Cantidad = 0
                };
                context.Parametros.Add(parametrouno);
                var parametrodos = new Tablas.Parametro()
                {
                    IdParametro = 2,
                    Descripcion = "Diario",
                    Estado = "A",
                    Orden = 2,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Valor = "1.00",
                    Costo = 1.00m,
                    TipoParametro = Tablas.TipoParametro.ValorPorUnidad,
                    Cantidad = 0
                };
                context.Parametros.Add(parametrodos);
                
                var parametrotres = new Tablas.Parametro()
                {
                    IdParametro = 3,
                    Descripcion = "Región",
                    Estado = "A",
                    Orden = 3,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    TipoParametro = Tablas.TipoParametro.Multiplo,
                    TieneOpciones = true,
                    OpcionesParametro = new List<Tablas.OpcionParametro>()
                    {
                        new Tablas.OpcionParametro()
                        {
                            Descripcion = "Costa",
                            IdParametro = 3,
                            Valor = 1m
                        },
                        new Tablas.OpcionParametro()
                        {
                            Descripcion = "Sierra",
                            IdParametro = 3,
                            Valor = 1.2m
                        }
                    }
                };
                context.Parametros.Add(parametrotres);
                var parametrocuatro = new Tablas.Parametro()
                {
                    IdParametro = 4,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    TipoParametro = Tablas.TipoParametro.Multiplo,
                    Descripcion = "Alcance",
                    Estado = "A", Orden = 7,
                    TieneOpciones = true,
                    OpcionesParametro = new List<Tablas.OpcionParametro>()
                    {
                        new Tablas.OpcionParametro()
                        {
                            Descripcion = "Llamadas Nacionales",
                            IdParametro = 4,
                            Valor = 1
                        },
                        new Tablas.OpcionParametro()
                        {
                            Descripcion = "Llamadas Internacionales",
                            IdParametro = 4,
                            Valor = 2.00m
                        }
                    }
                };

                var parametrocinco = new Tablas.Parametro()
                {
                    IdParametro = 5,
                    Descripcion = "% IVA",
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Costo = 0.12m,
                    Estado = "A",
                    Orden = 5,
                    TipoParametro = Tablas.TipoParametro.Impuesto
                };
                context.Parametros.Add(parametrocinco);

                var parametroseis = new Tablas.Parametro()
                {
                    IdParametro = 6,
                    Descripcion = "% ICE",
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Costo = 0.01m,
                    Estado = "A",
                    Orden = 6,
                    TipoParametro = Tablas.TipoParametro.Impuesto
                };
                context.Parametros.Add(parametroseis);

                context.SaveChanges();
                #endregion

                // add servicios ontime
                #region add servicios
                List<Tablas.Parametro> parametrosOntime = new List<Tablas.Parametro>();
                parametrosOntime.Add(parametrouno);
                parametrosOntime.Add(parametrocuatro);
                parametrosOntime.Add(parametrocinco);
                parametrosOntime.Add(parametroseis);
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 1,
                        Descripcion = "Internet 3G Familia",
                        Estado = "A",
                        Orden = 1,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Parametros = parametrosOntime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 2,
                        Descripcion = "Internet 4G Empresa",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Parametros = parametrosOntime
                    });
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 3,
                        Descripcion = "Paquete Llamadas",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OnTime,
                        Parametros = parametrosOntime
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

                //agregar servicios offline
                #region add serviciosOffLine
                List<Tablas.Parametro> parametros = new List<Tablas.Parametro>();
                parametros.Add(parametrouno);
                parametros.Add(parametrodos);
                parametros.Add(parametrotres);
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 4,
                        Descripcion = "Paquete Internet 3G Mensual",
                        Estado = "A",
                        Orden = 4,
                        TipoServicio = Tablas.TipoServicio.OffLine,
                        Parametros = parametros
                    });
                parametros = new List<Tablas.Parametro>();
                parametros.Add(parametrodos);
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 5,
                        Descripcion = "Paquete Internet 4G Diario",
                        Estado = "A",
                        Orden = 2,
                        TipoServicio = Tablas.TipoServicio.OffLine, 
                        Parametros = parametros
                    });
                parametros = new List<Tablas.Parametro>();
                parametros.Add(parametrotres);
                context.Servicios.Add(
                    new Tablas.Servicio()
                    {
                        IdServicio = 6,
                        Descripcion = "Telefonía Ilimitada",
                        Estado = "A",
                        Orden = 3,
                        TipoServicio = Tablas.TipoServicio.OffLine,
                        Parametros = parametros
                    });
                //save servicios offline
                context.SaveChanges();
                #endregion

                //agregar detalle ontime
                #region detalleOntime
                context.Detalles.Add(new Tablas.Detalle()
                {
                    IdCliente = 1,
                    IdDetalle = 1,
                    IdServicio = 1,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Costo = 20
                });
                context.Detalles.Add(new Tablas.Detalle()
                {
                    IdCliente = 2,
                    IdDetalle = 2,
                    IdServicio = 2,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Costo = 20
                });
                context.Detalles.Add(new Tablas.Detalle()
                {
                    IdCliente = 1,
                    IdDetalle = 3,
                    IdServicio = 3,
                    TipoServicio = Tablas.TipoServicio.OnTime,
                    Costo = 15
                });
                //save detalle ontime
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

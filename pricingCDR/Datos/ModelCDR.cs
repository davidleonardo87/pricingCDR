namespace pricingCDR.Datos
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ModelCDR : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'ModelCDR' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'pricingCDR.Datos.ModelCDR' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'ModelCDR'  en el archivo de configuración de la aplicación.
        public ModelCDR()
            : base("name=ModelCDR")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Tablas.Parametro> Parametros { get; set; }
        public virtual DbSet<Tablas.Cliente> Clientes { get; set; }
        public virtual DbSet<Tablas.Detalle> Detalles { get; set; }
        public virtual DbSet<Tablas.ParametroAdicional> ParametrosAdicionales { get; set; }
        public virtual DbSet<Tablas.Servicio> Servicios { get; set; }
        public virtual DbSet<Tablas.OpcionParametro> OpcionesParametro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //relacion detalle parametro adicional
            modelBuilder.Entity<Tablas.Detalle>()
                .HasMany<Tablas.ParametroAdicional>(d => d.ParametrosAdicionales)
                .WithMany(p => p.Detalles)
                .Map(dp =>
                {
                    dp.MapLeftKey("DetalleId");
                    dp.MapRightKey("ParametroAdicionalId");
                    dp.ToTable("DetalleParametroAdicional");
                });

            //relacion servicio parametro
            modelBuilder.Entity<Tablas.Servicio>()
                .HasMany<Tablas.Parametro>(s => s.Parametros)
                .WithMany(p => p.Servicios)
                .Map(sp=>{
                    sp.MapLeftKey("ServicioId");
                    sp.MapRightKey("ParametroId");
                    sp.ToTable("ServicioParametro");
                });
        }

    }


    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
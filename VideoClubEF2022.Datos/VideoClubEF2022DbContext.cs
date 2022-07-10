using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos
{
    public class VideoClubEF2022DbContext:DbContext
    {
        public VideoClubEF2022DbContext():base("name=MiConexion")
        {
            Database.CommandTimeout = 50;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<VideoClubEF2022DbContext>(null);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); 
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly()); 
        }
        //dbsets es la abstraccion de las tablas en EF

        public DbSet<Calificacion> Calificaciones { get; set; }
        //public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        //public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        //public DbSet<Socio> Socios { get; set; }
        public DbSet<Soporte> Soportes { get; set; }
        //public DbSet<TipoDocumento> TipoDocumentos { get; set; }


    }
}

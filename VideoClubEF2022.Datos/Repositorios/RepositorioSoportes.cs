using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioSoportes : IRepositorioSoportes
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioSoportes()
        {
            context = new VideoClubEF2022DbContext();
        }
        public void Borrar(int soporteId)
        {
            try
            {
                var soporteEnDb = context.Soportes
                    .SingleOrDefault(s => s.SoporteId == soporteId);
                if (soporteEnDb == null)
                {
                    throw new Exception("Soporte no encontrado");
                }
                context.Entry(soporteEnDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Soporte soporte)
        {
            try
            {
                return context.Peliculas
                    .Any(p => p.SoporteId == soporte.SoporteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Soporte soporte)
        {
            try
            {
                if (soporte.SoporteId == 0)
                {
                    return context.Soportes
                        .Any(s => s.Descripcion == soporte.Descripcion);
                }
                return context.Soportes.Any(s => s.Descripcion == soporte.Descripcion &&
                                                       s.SoporteId != soporte.SoporteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Soporte> GetSoporte()
        {
            try
            {
                return context.Soportes.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Soporte soporte)
        {
            try
            {
                if (soporte.SoporteId == 0)
                {
                    context.Soportes.Add(soporte);

                }
                else
                {
                    var soporteEnDb = context.Soportes
                        .SingleOrDefault(s => s.SoporteId == soporte.SoporteId);
                    if (soporteEnDb == null)
                    {
                        throw new Exception("Soporte no encontrado");
                    }

                    soporteEnDb.Descripcion = soporte.Descripcion;
                    context.Entry(soporteEnDb).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

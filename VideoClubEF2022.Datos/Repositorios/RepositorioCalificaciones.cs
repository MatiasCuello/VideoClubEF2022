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
    public class RepositorioCalificaciones:IRepositorioCalificaciones
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioCalificaciones()
        {
            context = new VideoClubEF2022DbContext();
        }

        public List<Calificacion> GetCalificacion()
        {
            try
            {
                return context.Calificaciones.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Calificacion calificacion)
        {
            try
            {
                if (calificacion.CalificacionId == 0)
                {
                    context.Calificaciones.Add(calificacion);

                }
                else
                {
                    var calificacionEnDb = context.Calificaciones
                            .SingleOrDefault(c => c.CalificacionId == calificacion.CalificacionId);
                    if (calificacionEnDb == null)
                    {
                        throw new Exception("Calificacion no encontrada");
                    }

                    calificacionEnDb.Descripcion = calificacion.Descripcion;
                    context.Entry(calificacionEnDb).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int calificacionId)
        {
            try
            {
                var calificacionEnDb = context.Calificaciones
                    .SingleOrDefault(c => c.CalificacionId == calificacionId);
                if (calificacionEnDb == null)
                {
                    throw new Exception("Calificacion no encontrada");
                }
                context.Entry(calificacionEnDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Calificacion calificacion)
        {
            try
            {
                if (calificacion.CalificacionId == 0)
                {
                    return context.Calificaciones
                        .Any(c => c.Descripcion == calificacion.Descripcion);
                }
                return context.Calificaciones.Any(c=>c.Descripcion == calificacion.Descripcion &&
                                                       c.CalificacionId != calificacion.CalificacionId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Calificacion calificacion)
        {
            try
            {
                return context.Peliculas
                    .Any(c => c.CalificacionId == calificacion.CalificacionId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}

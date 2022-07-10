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
    public class RepositorioEstados : IRepositorioEstados
    {

        private readonly VideoClubEF2022DbContext context;

        public RepositorioEstados()
        {
            context = new VideoClubEF2022DbContext();
        }
        public List<Estado> GetEstado()
        {
            try
            {
                return context.Estados.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Estado estado)
        {
            try
            {
                if (estado.EstadoId == 0)
                {
                    context.Estados.Add(estado);

                }
                else
                {
                    var estadoEnDB = context.Estados
                        .SingleOrDefault(e => e.EstadoId == estado.EstadoId);
                    if (estadoEnDB == null)
                    {
                        throw new Exception("Estado no encontrado");
                    }

                    estadoEnDB.Descripcion = estado.Descripcion;
                    context.Entry(estadoEnDB).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int estadoId)
        {
            try
            {
                var estadoEnDb = context.Estados
                    .SingleOrDefault(e => e.EstadoId == estadoId);
                if (estadoEnDb == null)
                {
                    throw new Exception("Estado no encontrado");
                }
                context.Entry(estadoEnDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                if (estado.EstadoId == 0)
                {
                    return context.Estados
                        .Any(e=>e.Descripcion == estado.Descripcion);
                }
                return context.Estados.Any(e => e.Descripcion == estado.Descripcion &&
                                                 e.EstadoId != estado.EstadoId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Estado estado)
        {
            try
            {
                return context.Peliculas
                    .Any(p => p.SoporteId == estado.EstadoId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public class RepositorioGeneros:IRepositorioGeneros
    {
        private readonly VideoClubEF2022DbContext context;
        public RepositorioGeneros()
        {
            context = new VideoClubEF2022DbContext();
        }

        public List<Genero> GetGenero()
        {
            try
            {
                return context.Generos.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Genero genero)
        {
            try
            {
                if (genero.GeneroId == 0)
                {
                    context.Generos.Add(genero);
                }
                else
                {
                    var generoEnDB = context.Generos
                        .SingleOrDefault(g => g.GeneroId == genero.GeneroId);
                    if (generoEnDB == null)
                    {
                        throw new Exception("Genero no encontrado");
                    }

                    generoEnDB.Descripcion = genero.Descripcion;
                    context.Entry(generoEnDB).State = EntityState.Modified;
                    context.SaveChanges();
                }
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int generoId)
        {
            try
            {
                var generoEnDB = context.Generos
                    .SingleOrDefault(g => g.GeneroId == generoId);
                if (generoEnDB == null)
                {
                    throw new Exception("Genero no encontrado");
                }
                context.Entry(generoEnDB).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Genero genero)
        {

            try
            {
                if (genero.GeneroId == 0)
                {
                    return context.Generos
                        .Any(g => g.Descripcion == genero.Descripcion);
                }
                return context.Generos.Any(g => g.Descripcion == genero.Descripcion &&
                                                g.GeneroId != genero.GeneroId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Genero genero)
        {
            try
            {
                return context.Peliculas
                    .Any(p => p.GeneroId == genero.GeneroId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioPeliculas:IRepositorioPeliculas
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioPeliculas()
        {
            context = new VideoClubEF2022DbContext();
        }

        public void Borrar(int peliculaId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }

        public List<Pelicula> GetLista()
        {
            throw new NotImplementedException();
        }

        public Localidad GetLocalidadPorId(int peliculaId)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Pelicula pelicula)
        {
            throw new NotImplementedException();
        }
    }
}

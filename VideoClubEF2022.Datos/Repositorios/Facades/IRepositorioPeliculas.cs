using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public interface IRepositorioPeliculas
    {
        List<Pelicula> GetLista();
        void Guardar(Pelicula pelicula);
        bool Existe(Pelicula pelicula);
        void Borrar(int peliculaId);
        bool EstaRelacionado(Pelicula pelicula);
        Localidad GetLocalidadPorId(int peliculaId);
    }
}

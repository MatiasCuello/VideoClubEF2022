using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public interface IRepositorioGeneros
    {
        List<Genero> GetGenero();
        void Guardar(Genero genero);
        void Borrar(int generoId);
        bool Existe(Genero genero);
        bool EstaRelacionado(Genero genero);
    }
}

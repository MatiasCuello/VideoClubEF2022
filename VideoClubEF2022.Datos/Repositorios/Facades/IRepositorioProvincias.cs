using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public interface IRepositorioProvincias
    {
        List<Provincia> GetLista();
        void Guardar(Provincia provincia);
        void Borrar(int provinciaId);
        bool Existe(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);
    }
}

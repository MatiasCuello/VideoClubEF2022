using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public interface IRepositorioProveedores
    {
        List<Proveedor> GetLista(Localidad localidad, Provincia provincia);
        void Guardar(Proveedor proveedor);
        void Borrar(int proveddorId);
        bool Existe(Proveedor proveedor);
        bool EstaRelacionado(Proveedor proveedor);
    }
}

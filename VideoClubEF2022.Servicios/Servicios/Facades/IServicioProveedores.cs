using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioProveedores
    {
        List<Proveedor> GetProveedores();
        bool Existe(Proveedor proveedor);
        void Guardar(Proveedor proveedor);
        bool EstaRelacionado(Proveedor proveedor);
    }
}

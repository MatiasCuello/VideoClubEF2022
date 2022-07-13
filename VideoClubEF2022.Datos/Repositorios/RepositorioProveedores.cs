using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioProveedores:IRepositorioProveedores
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioProveedores()
        {
            context = new VideoClubEF2022DbContext();
        }

        public void Borrar(int proveddorId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }

        public List<Proveedor> GetLista(Localidad localidad, Provincia provincia)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Proveedor proveedor)
        {
            throw new NotImplementedException();
        }
    }
}

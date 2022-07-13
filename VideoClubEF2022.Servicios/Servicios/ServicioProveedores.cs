using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios.Facades;

namespace VideoClubEF2022.Servicios.Servicios
{
    public class ServicioProveedores:IServicioProveedores
    {
        private readonly IRepositorioProveedores repositorio;

        public ServicioProveedores()
        {
            repositorio = new RepositorioProveedores();
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

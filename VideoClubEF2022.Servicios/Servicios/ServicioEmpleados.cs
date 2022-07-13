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
    public class ServicioEmpleados:IServicioEmpleados
    {
        private readonly IRepositorioEmpleados repositorio;

        public ServicioEmpleados()
        {
            repositorio = new RepositorioEmpleados();
        }

        public void Borrar(int empleadoId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetLista(Localidad localidad, Provincia provincia, TipoDocumento tipoDocumento)
        {
            throw new NotImplementedException();
        }

        public void Guardar(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}

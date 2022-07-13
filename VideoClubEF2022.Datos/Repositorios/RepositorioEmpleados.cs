using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioEmpleados:IRepositorioEmpleados
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioEmpleados()
        {
            context = new VideoClubEF2022DbContext();
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

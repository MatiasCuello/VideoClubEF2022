using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioEmpleados
    {
        List<Empleado> GetLista(Localidad localidad, Provincia provincia, TipoDocumento tipoDocumento);
        void Guardar(Empleado empleado);
        void Borrar(int empleadoId);
        bool Existe(Empleado empleado);
        bool EstaRelacionado(Empleado empleado);
    }
}

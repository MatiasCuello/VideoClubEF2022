using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioEstados
    {
        List<Estado> GetEstado();
        void Guardar(Estado estado);
        void Borrar(int estadoId);
        bool Existe(Estado estado);
        bool EstaRelacionado(Estado estado);
    }
}

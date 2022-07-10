using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioSoportes
    {
        List<Soporte> GetSoporte();
        void Guardar(Soporte soporte);
        void Borrar(int soporteId);
        bool Existe(Soporte soporte);
        bool EstaRelacionado(Soporte soporte);
    }
}

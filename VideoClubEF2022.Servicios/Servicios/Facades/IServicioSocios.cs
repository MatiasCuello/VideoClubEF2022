using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioSocios
    {
        List<Socio> GetLista(Localidad localidad, Provincia provincia,TipoDocumento tipoDocumento);
        void Guardar(Socio socio);
        void Borrar(int socioId);
        bool Existe(Socio socio);
        bool EstaRelacionado(Socio socio);
    }
}

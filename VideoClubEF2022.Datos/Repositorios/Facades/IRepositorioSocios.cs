using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
    public interface IRepositorioSocios
    {
        List<Socio> GetLista(Localidad localidad, Provincia provincia,TipoDocumento tipoDocumento);
        void Guardar(Socio socio);
        void Borrar(int socioId);
        bool Existe(Socio socio);
        

    }
}

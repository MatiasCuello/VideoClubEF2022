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
    public class ServicioTiposDocumentos : IServicioTiposDocumentos
    {
        private readonly IRepositorioTiposDocumentos repositorio;

        public ServicioTiposDocumentos()
        {
            repositorio = new RepositorioTiposDocumentos();
        }
        public List<TipoDocumento> GetLista()
        {
            return repositorio.GetLista();
        }
    }
}

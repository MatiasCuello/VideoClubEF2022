using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioTiposDocumentos : IRepositorioTiposDocumentos
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioTiposDocumentos()
        {
            context = new VideoClubEF2022DbContext();
        }
        public List<TipoDocumento> GetLista()
        {
            return context.TiposDocumentos
                .AsNoTracking().ToList();
        }
    }
}

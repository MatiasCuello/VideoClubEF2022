using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioSocios:IRepositorioSocios
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioSocios()
        {
            context = new VideoClubEF2022DbContext();
        }
        public void Borrar(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Socio socio)
        {
            throw new NotImplementedException();
        }

        public List<Socio> GetLista
            (Localidad localidad=null,Provincia provincia=null,TipoDocumento tipoDocumento=null)
        {
            try
            {
                var query = context.Socios
                        .Include(s => s.Localidad)
                        .Include(s => s.Provincia)
                        .Include(s => s.TipoDocumento)
                    ;
               if (localidad != null||provincia != null || tipoDocumento != null)
                {
                    query = query.Where(s => s.LocalidadId == localidad.LocalidadId );
                    query = query.Where(s => s.ProvinciaId == provincia.ProvinciaId);
                    query = query.Where(s => s.TipoDocuementoId == tipoDocumento.TipoDocumentoId);
                }
                return query.AsNoTracking().ToList();
                
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Socio socio)
        {
            throw new NotImplementedException();
        }
    }
}

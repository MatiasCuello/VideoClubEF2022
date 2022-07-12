using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public List<Socio> GetLista(Provincia provincia=null, Localidad localidad=null)
        {
            try
            {
                var queryProvincia = context.Socios
                    .Include(s=>s.Provincia);
                var queryLocalidad = context.Socios
                    .Include(s=>s.Localidad);
                if (provincia != null)
                {
                    queryProvincia = queryProvincia.Where(s => s.ProvinciaId == provincia.ProvinciaId);
                }
                if (localidad != null)
                {
                    queryLocalidad = queryLocalidad.Where(s => s.LocalidadId == localidad.LocalidadId);
                }
                return queryProvincia
                    .AsNoTracking()
                    .ToList();
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

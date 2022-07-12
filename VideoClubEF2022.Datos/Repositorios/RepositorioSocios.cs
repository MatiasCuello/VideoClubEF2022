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
        public void Borrar(int socioId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Socio socio)
        {
            try
            {
                if (socio.SocioId == 0)
                {
                    return context.Socios
                        .Any(s => s.Nombre == socio.Nombre && s.Apellido==socio.Apellido);
                }
                return context.Socios
                    .Any(s => s.Nombre == socio.Nombre &&
                              s.Apellido==socio.Apellido &&
                              s.SocioId != socio.SocioId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Socio> GetLista(Localidad localidad=null, Provincia provincia=null,TipoDocumento tipoDocumento=null)
        {
            try
            {
                var query = context.Socios
                    .Include(s => s.Localidad)
                    .Include(s => s.Provincia)
                    .Include(s=>s.TipoDocumento);

                if (localidad != null || provincia != null || tipoDocumento != null)
                {
                    query = query.Where(s => s.LocalidadId == localidad.LocalidadId);
                    query = query.Where(s => s.ProvinciaId == provincia.ProvinciaId);
                    query = query.Where(s => s.TipoDocumentoId == tipoDocumento.TipoDocumentoId);
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
            try
            {
                if (socio.SocioId == 0)
                {
                    context.Socios.Add(socio);
                }
                else
                {
                    var socioEnDB = context.Socios
                        .SingleOrDefault(s => s.SocioId == socio.SocioId);
                    if (socioEnDB == null)
                    {
                        throw new Exception("Código de socio inexistente...");
                    }

                    socioEnDB.Nombre = socio.Nombre;
                    socioEnDB.Apellido = socio.Apellido;
                    socioEnDB.TipoDocumentoId = socio.TipoDocumentoId;
                    socioEnDB.NroDocumento = socio.NroDocumento;
                    socioEnDB.Direccion = socio.Direccion;
                    socioEnDB.LocalidadId = socio.LocalidadId;
                    socioEnDB.ProvinciaId = socio.ProvinciaId;
                    socioEnDB.FechaNacimiento = socioEnDB.FechaNacimiento;
                    socioEnDB.Activo = socio.Activo;
                    socioEnDB.Sancionado = socio.Sancionado;


                    context.Entry(socioEnDB).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

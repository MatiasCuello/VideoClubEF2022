using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios.Facades;

namespace VideoClubEF2022.Servicios.Servicios
{
    public class ServicioSocios:IServicioSocios
    {
        private readonly RepositorioSocios repositorio;

        public ServicioSocios()
        {
            repositorio = new RepositorioSocios();
        }
        public List<Socio> GetLista(Localidad localidad,Provincia provincia,TipoDocumento tipoDocumento)
        {
            try
            {
                return repositorio.GetLista(localidad,provincia,tipoDocumento);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Guardar(Socio socio)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Socio socio)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Socio socio)
        {
            throw new NotImplementedException();
        }
    }
}

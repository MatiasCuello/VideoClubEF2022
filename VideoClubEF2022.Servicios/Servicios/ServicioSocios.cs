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
            try
            {
                repositorio.Guardar(socio);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Borrar(int socioid)
        {
            try
            {
                repositorio.Borrar(socioid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Existe(Socio socio)
        {
            try
            {
                return repositorio.Existe(socio);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}

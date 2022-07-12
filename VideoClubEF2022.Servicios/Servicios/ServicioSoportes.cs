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
    public class ServicioSoportes:IServicioSoportes
    {
        private readonly IRepositorioSoportes repositorio;

        public ServicioSoportes()
        {
            repositorio = new RepositorioSoportes();
        }
        public List<Soporte> GetLista()
        {
            try
            {
                return repositorio.GetLista();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Soporte soporte)
        {
            try
            {
                repositorio.Guardar(soporte);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int soporteId)
        {
            try
            {
                repositorio.Borrar(soporteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Soporte soporte)
        {
            try
            {
                return repositorio.Existe(soporte);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Soporte soporte)
        {
            try
            {
                return repositorio.EstaRelacionado(soporte);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

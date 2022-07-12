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
    public class ServicioEstados:IServicioEstados
    {
        private readonly IRepositorioEstados repositorio;

        public ServicioEstados()
        {
            repositorio = new RepositorioEstados();
        }

        public List<Estado> GetLista()
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

        public void Guardar(Estado estado)
        {
            try
            {
                repositorio.Guardar(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int estadoId)
        {
            try
            {
                repositorio.Borrar(estadoId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Estado estado)
        {
            try
            {
                return repositorio.Existe(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Estado estado)
        {
            try
            {
                return repositorio.EstaRelacionado(estado);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios.Facades;

namespace VideoClubEF2022.Servicios
{
    public class ServicioGeneros:IServicioGeneros
    {
        private readonly IRepositorioGeneros repositorio;

        public ServicioGeneros()
        {
            repositorio = new RepositorioGeneros();
        }
        public List<Genero> GetGenero()
        {
            try
            {
                return repositorio.GetGenero();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Genero genero)
        {
            try
            { 
                repositorio.Guardar(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int generoId)
        {
            try
            {
                repositorio.Borrar(generoId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Genero genero)
        {
            try
            {
                return repositorio.Existe(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Genero genero)
        {
            try
            {
                return repositorio.EstaRelacionado(genero);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

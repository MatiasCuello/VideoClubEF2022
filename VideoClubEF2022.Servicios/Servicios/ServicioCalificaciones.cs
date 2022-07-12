using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos;
using VideoClubEF2022.Datos.Repositorios;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios.Facades;

namespace VideoClubEF2022.Servicios.Servicios
{
    public class ServicioCalificaciones : IServicioCalificaciones
    {
        private readonly IRepositorioCalificaciones repositorio;

        public ServicioCalificaciones()
        {
            repositorio = new RepositorioCalificaciones();
        }

        public void Borrar(int calificacionId)
        {
            try
            {
                repositorio.Borrar(calificacionId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Calificacion calificacion)
        {
            try
            {
                return repositorio.EstaRelacionado(calificacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Calificacion calificacion)
        {
            try
            {
                return repositorio.Existe(calificacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Calificacion> GetLista()
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

        public void Guardar(Calificacion calificacion)
        {
            try
            {
                repositorio.Guardar(calificacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

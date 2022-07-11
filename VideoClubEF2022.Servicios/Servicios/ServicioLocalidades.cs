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
    public class ServicioLocalidades : IServicioLocalidades
    {
        private readonly IRepositorioLocalidades repositorio;

        public ServicioLocalidades()
        {
            repositorio = new RepositorioLocalidades();
        }
        public void Borrar(int localidadId)
        {

            try
            {
                repositorio.Borrar(localidadId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                return repositorio.EstaRelacionado(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                return repositorio.Existe(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Localidad> GetLista(Provincia provincia)
        {
            try
            {
                return repositorio.GetLista(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Localidad localidad)
        {

            try
            {
                repositorio.Guardar(localidad);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

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
    public class ServicioProvincias : IServicioProvincias
    {
        private readonly IRepositorioProvincias repositorio;

        public ServicioProvincias()
        {
            repositorio = new RepositorioProvincias();
        }
        public void Borrar(int provinciaId)
        {
            try
            {
                repositorio.Borrar(provinciaId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Provincia provincia)
        {
            try
            {
                return repositorio.EstaRelacionado(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                return repositorio.Existe(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Provincia> GetProvincia()
        {
            try
            {
                return repositorio.GetProvincia();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Provincia provincia)
        {
            try
            {
                repositorio.Guardar(provincia);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}

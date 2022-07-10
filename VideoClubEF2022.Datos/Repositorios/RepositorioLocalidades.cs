using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Datos.Repositorios.Facades;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios
{
    public class RepositorioLocalidades:IRepositorioLocalidades
    {
        private readonly VideoClubEF2022DbContext context;

        public RepositorioLocalidades()
        {
            context = new VideoClubEF2022DbContext();
        }
    

        public void Guardar(Localidad localidad)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Localidad localidad)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int Id)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            throw new NotImplementedException();
        }

        public Localidad GetLocalidadPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Localidad> GetLocalidad(Provincia provincia)
        {
            throw new NotImplementedException();
        }

        

    }
}


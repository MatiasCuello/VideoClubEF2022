using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.Repositorios.Facades
{
   public interface IRepositorioLocalidades
    {
        List<Localidad> GetLocalidad(Provincia provincia);
        void Guardar(Localidad localidad);
        bool Existe(Localidad localidad);
        void Borrar(int localidadId);
        bool EstaRelacionado(Localidad localidad);
        Localidad GetLocalidadPorId(int id);


    }
}

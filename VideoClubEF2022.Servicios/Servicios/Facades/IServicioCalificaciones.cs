using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Servicios.Servicios.Facades
{
    public interface IServicioCalificaciones
    {
        List<Calificacion> GetLista();
        void Guardar(Calificacion calificacion);
        void Borrar(int calificacionId);
        bool Existe(Calificacion calificacion);
        bool EstaRelacionado(Calificacion calificacion);
    }
}

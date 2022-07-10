using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubEF2022.Entidades
{
    public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Titulo { get; set; }
        public int GeneroId { get; set; }
        public DateTime FechaIncorporacion { get; set; }
        public int EstadoId { get; set; }
        public double DuracionEnMinutos { get; set; }
        public int CalificacionId { get; set; }
        public bool Alquilado { get; set; } = false;
        public bool Activa { get; set; } = true;
        public string Observaciones { get; set; }
        public int SoporteId { get; set; }

    }
}

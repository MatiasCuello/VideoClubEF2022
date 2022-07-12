using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubEF2022.Entidades
{
    public class Socio
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocumentoId { get; set; }
        public string NroDocumento { get; set; }
        public string Direccion { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Sancionado { get; set; } = false;
        public bool Activo { get; set; } = true;

        public Localidad Localidad { get; set; }
        public Provincia Provincia { get; set; }
        public TipoDocumento TipoDocumento { get; set; }





    }
}

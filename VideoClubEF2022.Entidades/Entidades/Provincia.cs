using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClubEF2022.Entidades
{
    public class Provincia : ICloneable
    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }
        public virtual ICollection<Localidad> Localidades { get; set; } = new List<Localidad>();

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

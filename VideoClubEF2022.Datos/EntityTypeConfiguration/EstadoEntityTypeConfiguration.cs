using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Datos.EntityTypeConfigurations
{
    public class EstadoEntityTypeConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoEntityTypeConfiguration()
        {
            ToTable("Estados");
        }
    }
}

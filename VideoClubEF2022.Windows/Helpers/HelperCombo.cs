using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios;
using VideoClubEF2022.Servicios.Servicios.Facades;

namespace VideoClubEF2022.Windows.Helpers
{
    public static class HelperCombo
    {
        public static void CargarDatosComboProvincias(ref ComboBox combo)
        {
            IServicioProvincias servicio = new ServicioProvincias();
            var lista = servicio.GetLista();
            Provincia provinciaDefault = new Provincia()
            {
                ProvinciaId = 0,
                NombreProvincia = "<Seleccionar Provincia>"
            };
            lista.Insert(0, provinciaDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreProvincia";
            combo.ValueMember = "ProvinciaId";
            combo.SelectedIndex = 0;
        }
    }
}

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
        public static void CargarDatosComboLocalidades(ref ComboBox combo)
        {
            IServicioLocalidades servicio = new ServicioLocalidades();
            var lista = servicio.GetLista(null);
            Localidad localidadDefault = new Localidad()
            {
                LocalidadId = 0,
                NombreLocalidad = "<Seleccionar Localidad>"
            };
            lista.Insert(0, localidadDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "LocalidadId";
            combo.SelectedIndex = 0;
        }
        public static void CargarDatosComboTiposDocumentos(ref ComboBox combo)
        {
            IServicioTiposDocumentos servicio = new ServicioTiposDocumentos();
            var lista = servicio.GetLista();
            TipoDocumento tpDefault = new TipoDocumento()
            {
                TipoDocumentoId = 0,
                Descripcion = "<Seleccionar Tipo Documento>"
            };
            lista.Insert(0, tpDefault);
            combo.DataSource = lista;
            combo.DisplayMember = "Descripcion";
            combo.ValueMember = "TipoDocumentoId";
            combo.SelectedIndex = 0;
        }
    }
}

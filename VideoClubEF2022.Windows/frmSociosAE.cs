using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios;
using VideoClubEF2022.Servicios.Servicios.Facades;
using VideoClubEF2022.Windows.Helpers;

namespace VideoClubEF2022.Windows
{
    public partial class frmSociosAE : Form
    {
        public frmSociosAE()
        {
            InitializeComponent();
        }

        private Socio socio;
        private IServicioSocios servicio;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            servicio = new ServicioSocios();
            HelperCombo.CargarDatosComboTiposDocumentos(ref TipoDocumentoComboBox);
            HelperCombo.CargarDatosComboLocalidades(ref LocalidadesComboBox);
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasComboBox);
            if (socio != null)
            {
                NombreTextBox.Text = socio.Nombre;
                ApellidoTextBox.Text = socio.Apellido;
                TipoDocumentoComboBox.SelectedValue = socio.TipoDocumento.Descripcion;
                NroDocumentoTextBox.Text = socio.NroDocumento;
                DireccionTextBox.Text = socio.Direccion;
                LocalidadesComboBox.SelectedValue = socio.Localidad.NombreLocalidad;
                ProvinciasComboBox.SelectedValue = socio.Provincia.NombreProvincia;
                FechaNacDateTimePicker.Value = socio.FechaNacimiento;

            }
        }
    


        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Socio GetSocio()
        {
            return socio;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (socio == null)
                {
                    socio = new Socio();
                }

                socio.Nombre = NombreTextBox.Text;
                socio.Apellido = ApellidoTextBox.Text;
                socio.TipoDocumento = ((TipoDocumento)TipoDocumentoComboBox.SelectedItem);
                socio.NroDocumento = NroDocumentoTextBox.Text;
                socio.Direccion = DireccionTextBox.Text;
                socio.Localidad = ((Localidad)LocalidadesComboBox.SelectedItem);
                socio.Provincia = ((Provincia)ProvinciasComboBox.SelectedItem);
                socio.FechaNacimiento = FechaNacDateTimePicker.Value;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NombreTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NombreTextBox, "El Nombre es requerido");
            }

            if (string.IsNullOrEmpty(ApellidoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(ApellidoTextBox, "El Apellido es requerido");
            }

            if (TipoDocumentoComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(TipoDocumentoComboBox, "Debe seleccionar un tipo de documento");
            }

            if (string.IsNullOrEmpty(NroDocumentoTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(NroDocumentoTextBox, "El nro de documento es requerido");
            }

            if (string.IsNullOrEmpty(DireccionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(DireccionTextBox, "La direccion es requerido");
            }

            if (LocalidadesComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(LocalidadesComboBox, "Debe seleccionar una localidad");
            }

            if (ProvinciasComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasComboBox, "Debe seleccionar una provincia");
            }

            if (FechaNacDateTimePicker.Value.Date==DateTime.Now.Date )
            {
                valido = false;
                errorProvider1.SetError(FechaNacDateTimePicker, "Debe seleccionar una fecha");
            }

            return valido;
        }


    }
}


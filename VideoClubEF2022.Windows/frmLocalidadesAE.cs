using System;
using System.Windows.Forms;
using VideoClubEF2022.Entidades;
using VideoClubEF2022.Servicios.Servicios;
using VideoClubEF2022.Windows.Helpers;

namespace VideoClubEF2022.Windows
{
    public partial class frmLocalidadesAE : Form
    {
        public frmLocalidadesAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var servicio = new ServicioLocalidades();
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasComboBox);
            if (localidad != null)
            {
                LocalidadTextBox.Text = localidad.NombreLocalidad;
                ProvinciasComboBox.SelectedValue = localidad.ProvinciaId;
            }
        }

        private Localidad localidad;

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Localidad GetLocalidad()
        {
            return localidad;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (localidad == null)
                {
                    localidad = new Localidad();
                }

                localidad.NombreLocalidad = LocalidadTextBox.Text;
                localidad.ProvinciaId =(int) ProvinciasComboBox.SelectedValue;
                //localidad.Provincia = (Provincia) ProvinciasComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(LocalidadTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(LocalidadTextBox, "Debe agregar una localidad");
            }
            if (ProvinciasComboBox.SelectedIndex == 0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasComboBox, "Debe seleccionar una provincia");
            }

            return valido;
        }

        public void SetLocalidad(Localidad l)
        {
           this.localidad = l;
        }
    }
}

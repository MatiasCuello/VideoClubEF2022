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

namespace VideoClubEF2022.Windows
{
    public partial class frmCalificacionesAE : Form
    {
        public frmCalificacionesAE()
        {
            InitializeComponent();
        }
        private Calificacion calificacion;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (calificacion != null)
            {
                CalificacionTextBox.Text = calificacion.Descripcion;
            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (calificacion == null)
                {
                    calificacion = new Calificacion();
                }
                calificacion.Descripcion = CalificacionTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(CalificacionTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(CalificacionTextBox, "Debe ingresar una calificacion");
            }

            return valido;
        }

        public Calificacion GetCalificacion()
        {
            return calificacion;
        }

        public void SetCalificacion(Calificacion calificacion)
        {
            this.calificacion = calificacion;
        }
    }

}

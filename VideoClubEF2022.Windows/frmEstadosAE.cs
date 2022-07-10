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
    public partial class frmEstadosAE : Form
    {
        public frmEstadosAE()
        {
            InitializeComponent();
        }
        private Estado estado;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (estado != null)
            {
                EstadosTextBox.Text = estado.Descripcion;
            }
        }

        public void SetEstado(Estado es)
        {
            this.estado = es;
        }

        public Estado GetEstado()
        {
            return estado;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (estado == null)
                {
                    estado = new Estado();
                }
                estado.Descripcion = EstadosTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(EstadosTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(EstadosTextBox, "Debe ingresar un soporte");
            }

            return valido;
        }
    }
}

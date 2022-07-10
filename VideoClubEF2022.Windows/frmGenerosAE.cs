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
    public partial class frmGenerosAE : Form
    {
        public frmGenerosAE()
        {
            InitializeComponent();
        }

        private Genero genero;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (genero != null)
            {
                GeneroTextBox.Text = genero.Descripcion;
            }
        }

        public Genero GetGenero()
        {
            return genero;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                if (genero == null)
                {
                    genero = new Genero();
                }

                genero.Descripcion = GeneroTextBox.Text.Trim();
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            if (string.IsNullOrEmpty(GeneroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(GeneroTextBox, "Debe ingresar un genero");
            }

            return valido;
        }

        public void SetGenero(Genero genero)
        {
            this.genero = genero;
        }
    }
}

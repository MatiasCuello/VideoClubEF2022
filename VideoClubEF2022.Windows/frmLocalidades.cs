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
    public partial class frmLocalidades : Form
    {
        public frmLocalidades()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IServicioLocalidades servicio;
        private List<Localidad> lista;
        private void frmLocalidades_Load(object sender, EventArgs e)
        {
            servicio = new ServicioLocalidades();
            try
            {
                lista = servicio.GetLocalidad(null);
                HelperForm.MostrarDatosEnGrilla(dgvDatos,lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmLocalidadesAE frm = new frmLocalidadesAE();
            frm.ShowDialog(this);
        }
    }
}

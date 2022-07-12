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
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }
        
        private IServicioSocios servicio;
        private List<Socio> lista;

        private void frmSocios_Load(object sender, EventArgs e)
        {
            servicio = new ServicioSocios();
            try
            {
                lista = servicio.GetLista(null,null,null);
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmSociosAE frm = new frmSociosAE()
                {Text = "Nuevo Socio"};
            frm.ShowDialog(this);
        }
    }
}

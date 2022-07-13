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
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Socio socio = frm.GetSocio();
                if (!servicio.Existe(socio))
                {
                    servicio.Guardar(socio);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, socio);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Socio agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Socio repetido, alta denegada", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dgvDatos.SelectedRows[0];
            Socio socio = (Socio)r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar el socio {socio.Nombre} {socio.Apellido}?",
                "Confirmar Eliminacion");
            if (dr == DialogResult.No)
            {
                return;
            }
            try
            {   
                    servicio.Borrar(socio.SocioId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Socio eliminado",
                        "Mensaje");
             
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message,
                    "Error");
            }
        }
    }
}

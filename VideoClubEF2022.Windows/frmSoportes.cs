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
    public partial class frmSoportes : Form
    {
        public frmSoportes()
        {
            InitializeComponent();
        }

        private IServicioSoportes servicio;
        private List<Soporte> lista;

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSoportes_Load(object sender, EventArgs e)
        {
            servicio = new ServicioSoportes();
            try
            {
                lista = servicio.GetLista();
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmSoportesAE frm = new frmSoportesAE()
            { Text = "Agregar Soporte" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Soporte soporte = frm.GetSoporte();
                if (!servicio.Existe(soporte))
                {
                    servicio.Guardar(soporte);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, soporte);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Soporte agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Soporte repetido, alta denegada", "Error");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Mensaje", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Soporte s = (Soporte)r.Tag;
            Soporte soporteAuxiliar = (Soporte)s.Clone();
            frmSoportesAE frm = new frmSoportesAE()
            { Text = "Edita Soporte" };
            frm.SetSoporte(s);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                s = frm.GetSoporte();
                if (!servicio.Existe(s))
                {
                    servicio.Guardar(s);
                    HelperGrilla.SetearFila(r, s);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Calificacion modificada", "Mensaje");

                }
                else
                {
                    HelperGrilla.SetearFila(r, soporteAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "No se pudo modificar la calificacion ", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, soporteAuxiliar);
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            try
            {
                var r = dgvDatos.SelectedRows[0];
                Soporte s = (Soporte)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar el soporte seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(s))
                {
                    servicio.Borrar(s.SoporteId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Soporte eliminado!", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Soporte relacionado, baja denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

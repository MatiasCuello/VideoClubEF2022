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
    public partial class frmEstados : Form
    {
        public frmEstados()
        {
            InitializeComponent();
        }

        private IServicioEstados servicio;
        private List<Estado> lista;

        private void tsbCerrar_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmEstadosAE frm = new frmEstadosAE()
                { Text = "Agregar Estado" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Estado estado = frm.GetEstado();
                if (!servicio.Existe(estado))
                {
                    servicio.Guardar(estado);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, estado);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Estado agregado", "Mensaje");

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
            Estado es = (Estado)r.Tag;
            Estado estadoAuxiliar = (Estado)es.Clone();
            frmEstadosAE frm = new frmEstadosAE()
                { Text = "Editar Estado" };
            frm.SetEstado(es);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                es = frm.GetEstado();
                if (!servicio.Existe(es))
                {
                    servicio.Guardar(es);
                    HelperGrilla.SetearFila(r, es);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Estado modificado", "Mensaje");

                }
                else
                {
                    HelperGrilla.SetearFila(r, estadoAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "No se pudo modificar el estado ", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, estadoAuxiliar);
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
                Estado es = (Estado)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar el estado seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(es))
                {
                    servicio.Borrar(es.EstadoId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Estado eliminado!", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Estado relacionado, baja denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }

        private void frmEstados_Load(object sender, EventArgs e)
        {
            servicio = new ServicioEstados();
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
    }
}

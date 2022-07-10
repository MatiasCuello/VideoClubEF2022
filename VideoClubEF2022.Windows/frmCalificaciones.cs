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
    public partial class frmCalificaciones : Form
    {
        public frmCalificaciones()
        {
            InitializeComponent();
        }

        private IServicioCalificaciones servicio;
        private List<Calificacion> lista;

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmCalificaciones_Load(object sender, EventArgs e)
        {
            servicio = new ServicioCalificaciones();
            try
            {
                lista = servicio.GetCalificacion();
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
            frmCalificacionesAE frm = new frmCalificacionesAE()
                {Text = "Agregar Categoria"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Calificacion calificacion = frm.GetCalificacion();
                if (!servicio.Existe(calificacion))
                {
                    servicio.Guardar(calificacion);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, calificacion);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Calificacion agregada", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Calificacion repetida, alta denegada", "Error");
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

            try
            {
                var r = dgvDatos.SelectedRows[0];
                Calificacion c = (Calificacion) r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar la calificacion seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(c))
                {
                    servicio.Borrar(c.CalificacionId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Calificacion eliminada!", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Calificacion relacionada, baja denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Calificacion c = (Calificacion)r.Tag;
            Calificacion calificacionAuxiliar = (Calificacion)c.Clone();
            frmCalificacionesAE frm = new frmCalificacionesAE()
                { Text = "Edita calificacion" };
            frm.SetCalificacion(c);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                c = frm.GetCalificacion();
                if (!servicio.Existe(c))
                {
                    servicio.Guardar(c);
                    HelperGrilla.SetearFila(r, c);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Calificacion modificada", "Mensaje");

                }
                else
                {
                    HelperGrilla.SetearFila(r, calificacionAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "No se pudo modificar la calificacion ", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, calificacionAuxiliar);
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }
    }
}

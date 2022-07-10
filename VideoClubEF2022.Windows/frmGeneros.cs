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
using VideoClubEF2022.Servicios;
using VideoClubEF2022.Servicios.Servicios.Facades;
using VideoClubEF2022.Windows.Helpers;

namespace VideoClubEF2022.Windows
{
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }
        private void frmGeneros_Load(object sender, EventArgs e)
        {
            servicio = new ServicioGeneros();
            try
            {
                lista = servicio.GetGenero();
                HelperForm.MostrarDatosEnGrilla(dgvDatos, lista);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        private IServicioGeneros servicio;
        private List<Genero> lista;

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmGenerosAE frm = new frmGenerosAE()
                { Text = "Agregar Genero" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Genero genero = frm.GetGenero();
                if (!servicio.Existe(genero))
                {
                    servicio.Guardar(genero);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, genero);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Genero agregado", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Genero repetido, alta denegada", "Error");
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
            Genero g = (Genero)r.Tag;
            Genero generoAuxiliar = (Genero)g.Clone();
            frmGenerosAE frm = new frmGenerosAE()
                { Text = "Edita Genero" };
            frm.SetGenero(g);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                g = frm.GetGenero();
                if (!servicio.Existe(g))
                {
                    servicio.Guardar(g);
                    HelperGrilla.SetearFila(r, g);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Genero modificado", "Mensaje");

                }
                else
                {
                    HelperGrilla.SetearFila(r, generoAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "No se pudo modificar el genero ", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, generoAuxiliar);
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
                Genero g = (Genero)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar el genero seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(g))
                {
                    servicio.Borrar(g.GeneroId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Genero eliminado!", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Genero relacionado, baja denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }
    }
}

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
    public partial class frmProvincias : Form
    {
        public frmProvincias()
        {
            InitializeComponent();
        }

        private IServicioProvincias servicio;
        private List<Provincia> lista;

        private void frmProvincias_Load(object sender, EventArgs e)
        {
            servicio = new ServicioProvincias();
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

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            frmProvinciasAE frm = new frmProvinciasAE()
                { Text = "Agregar Provincia" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Provincia provincia = frm.GetProvincia();
                if (!servicio.Existe(provincia))
                {
                    servicio.Guardar(provincia);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, provincia);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Provincia agregada", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Provincia repetida, alta denegada", "Error");
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
            Provincia p = (Provincia)r.Tag;
            Provincia provinciaAuxiliar = (Provincia)p.Clone();
            frmProvinciasAE frm = new frmProvinciasAE()
                { Text = "Editar Provincia" };
            frm.SetProvincia(p);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                p = frm.GetProvincia();
                if (!servicio.Existe(p))
                {
                    servicio.Guardar(p);
                    HelperGrilla.SetearFila(r, p);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Provincia modificada", "Mensaje");

                }
                else
                {
                    HelperGrilla.SetearFila(r, provinciaAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Provincia repetida\nModificacion denegada ", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, provinciaAuxiliar);
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
                Provincia p = (Provincia)r.Tag;
                DialogResult dr = MessageBox.Show("¿Desea eliminar la provincia seleccionada?",
                    "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No)
                {
                    return;
                }

                if (!servicio.EstaRelacionado(p))
                {
                    servicio.Borrar(p.ProvinciaId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Provincia eliminada!", "Mensaje");

                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Provincia relacionada, baja denegada", "Error");

                }
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");

            }
        }
    }
}

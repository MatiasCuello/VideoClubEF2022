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
                lista = servicio.GetLista(null);
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
            frmLocalidadesAE frm = new frmLocalidadesAE()
                {Text = "Agregar Localidad"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                Localidad localidad = frm.GetLocalidad();
                if (!servicio.Existe(localidad))
                {
                    servicio.Guardar(localidad);
                    DataGridViewRow r = HelperGrilla.ConstruirFila(dgvDatos);
                    HelperGrilla.SetearFila(r, localidad);
                    HelperGrilla.AgregarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Localidad agregada", "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Localidad repetida\nalta denegada", "Error");

                }

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }

            var r = dgvDatos.SelectedRows[0];
            Localidad l = (Localidad) r.Tag;
            DialogResult dr = HelperMensaje.Mensaje($"¿Desea borrar la localidad {l.NombreLocalidad}?",
                "Confirmar eliminacion");
            if (dr == DialogResult.No)
            {
                return;
            }

            try
            {
                if (!servicio.EstaRelacionado(l))
                {
                    servicio.Borrar(l.LocalidadId);
                    HelperGrilla.BorrarFila(dgvDatos, r);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Localidad eliminada",
                        "Mensaje");
                }
                else
                {
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Localidad relacionadad\nBaja denegada!", "Error");

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
            Localidad l = (Localidad) r.Tag;
            Localidad localidadAuxiliar = (Localidad) l.Clone();

            try
            {
                frmLocalidadesAE frm = new frmLocalidadesAE()
                    {Text = "Editar localidad"};
                frm.SetLocalidad(l);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                l = frm.GetLocalidad();
                if (!servicio.Existe(l))
                {
                    servicio.Guardar(l);
                    HelperGrilla.SetearFila(r, l);
                    HelperMensaje.Mensaje(TipoMensaje.OK, "Localidad editada", "Mensaje");
                }
                else
                {
                    HelperGrilla.SetearFila(r, localidadAuxiliar);
                    HelperMensaje.Mensaje(TipoMensaje.ERROR, "Localidad existente..", "Error");
                }

            }
            catch (Exception exception)
            {
                HelperGrilla.SetearFila(r, localidadAuxiliar);

                HelperMensaje.Mensaje(TipoMensaje.ERROR, exception.Message, "Error");
            }
        }

        
    }
}

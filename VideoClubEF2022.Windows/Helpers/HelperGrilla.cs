using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClubEF2022.Entidades;

namespace VideoClubEF2022.Windows.Helpers
{
    public static class HelperGrilla
    {
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;

        }

        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Calificacion c:
                    r.Cells[0].Value = ((Calificacion)obj).Descripcion;
                    break;

                case Soporte s:
                    r.Cells[0].Value = ((Soporte)obj).Descripcion;
                    break;

                case Estado es:
                    r.Cells[0].Value = ((Estado)obj).Descripcion;
                    break;

                case Genero g:
                    r.Cells[0].Value = ((Genero)obj).Descripcion;
                    break;

                case Provincia p:
                    r.Cells[0].Value = ((Provincia)obj).NombreProvincia;
                    break;

                case Localidad l:
                    r.Cells[0].Value = ((Localidad)obj).NombreLocalidad;
                    r.Cells[1].Value = ((Localidad)obj).Provincia.NombreProvincia;
                    break;

                case Socio s:
                    r.Cells[0].Value = ((Socio) obj).Nombre;
                    r.Cells[1].Value = ((Socio) obj).Apellido;
                    r.Cells[2].Value = ((Socio) obj).Direccion;
                    r.Cells[3].Value = ((Socio) obj).Localidad.NombreLocalidad;
                    r.Cells[4].Value = ((Socio) obj).Provincia.NombreProvincia;
                    r.Cells[5].Value = ((Socio) obj).Activo;
                    r.Cells[6].Value = ((Socio) obj).Sancionado;
                    break;

            }

            r.Tag = obj;

        }
    }
}

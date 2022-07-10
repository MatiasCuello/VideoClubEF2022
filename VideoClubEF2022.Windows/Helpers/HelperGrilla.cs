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
                    r.Cells[0].Value = ((Genero) obj).Descripcion;
                    break;
                case Provincia p:
                    r.Cells[0].Value = ((Provincia)obj).NombreProvincia;
                    break;
                case Localidad l:
                    r.Cells[0].Value = ((Localidad) obj).NombreLocalidad;
                    r.Cells[1].Value = ((Localidad) obj).Provincia.NombreProvincia;
                    break;


            }

            r.Tag = obj;

        }
    }
}

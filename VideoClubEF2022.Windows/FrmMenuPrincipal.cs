using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClubEF2022.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void CalificacionesButton_Click(object sender, EventArgs e)
        {
            frmCalificaciones frm = new frmCalificaciones()
                {Text = "Calificaciones" };
            frm.ShowDialog(this);
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SoportesButton_Click(object sender, EventArgs e)
        {
            frmSoportes frm = new frmSoportes()
                { Text = "Soportes" };
            frm.ShowDialog(this);
        }

        private void EstadosButton_Click(object sender, EventArgs e)
        {
            frmEstados frm = new frmEstados()
                { Text = "Estados" };
            frm.ShowDialog(this);
        }

        private void GenerosButton_Click(object sender, EventArgs e)
        {
            frmGeneros frm = new frmGeneros()
                { Text = "Generos" };
            frm.ShowDialog(this);
        }

        private void ProvinciasButton_Click(object sender, EventArgs e)
        {
            frmProvincias frm = new frmProvincias()
                { Text = "Provincias" };
            frm.ShowDialog(this);
        }
    }
}


namespace VideoClubEF2022.Windows
{
    partial class frmPeliculas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.tsLocalidades = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.cmnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaIncorporacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnAlquilado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tsLocalidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 407);
            this.panel1.TabIndex = 13;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnTitulo,
            this.cmnGenero,
            this.cmnFechaIncorporacion,
            this.cmnEstado,
            this.cmnDuracion,
            this.cmnCalificacion,
            this.cmnAlquilado,
            this.cmnActivo});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(784, 407);
            this.dgvDatos.TabIndex = 1;
            // 
            // tsLocalidades
            // 
            this.tsLocalidades.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbBorrar,
            this.tsbCerrar});
            this.tsLocalidades.Location = new System.Drawing.Point(0, 0);
            this.tsLocalidades.Name = "tsLocalidades";
            this.tsLocalidades.Size = new System.Drawing.Size(784, 54);
            this.tsLocalidades.TabIndex = 12;
            this.tsLocalidades.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.Image = global::VideoClubEF2022.Windows.Properties.Resources.Nuevo;
            this.tsbNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(46, 51);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            this.tsbEditar.Image = global::VideoClubEF2022.Windows.Properties.Resources.Editar;
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(41, 51);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbBorrar
            // 
            this.tsbBorrar.Image = global::VideoClubEF2022.Windows.Properties.Resources.Borrar;
            this.tsbBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrar.Name = "tsbBorrar";
            this.tsbBorrar.Size = new System.Drawing.Size(43, 51);
            this.tsbBorrar.Text = "Borrar";
            this.tsbBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbCerrar.Image = global::VideoClubEF2022.Windows.Properties.Resources.Salir;
            this.tsbCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(43, 51);
            this.tsbCerrar.Text = "Cerrar";
            this.tsbCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // cmnTitulo
            // 
            this.cmnTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnTitulo.HeaderText = "Titulo";
            this.cmnTitulo.Name = "cmnTitulo";
            this.cmnTitulo.ReadOnly = true;
            // 
            // cmnGenero
            // 
            this.cmnGenero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnGenero.HeaderText = "Genero";
            this.cmnGenero.Name = "cmnGenero";
            this.cmnGenero.ReadOnly = true;
            // 
            // cmnFechaIncorporacion
            // 
            this.cmnFechaIncorporacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnFechaIncorporacion.HeaderText = "Fecha Incorp.";
            this.cmnFechaIncorporacion.Name = "cmnFechaIncorporacion";
            this.cmnFechaIncorporacion.ReadOnly = true;
            // 
            // cmnEstado
            // 
            this.cmnEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnEstado.HeaderText = "Estado";
            this.cmnEstado.Name = "cmnEstado";
            this.cmnEstado.ReadOnly = true;
            // 
            // cmnDuracion
            // 
            this.cmnDuracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDuracion.HeaderText = "Duracion(min)";
            this.cmnDuracion.Name = "cmnDuracion";
            this.cmnDuracion.ReadOnly = true;
            // 
            // cmnCalificacion
            // 
            this.cmnCalificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCalificacion.HeaderText = "Calificacion";
            this.cmnCalificacion.Name = "cmnCalificacion";
            this.cmnCalificacion.ReadOnly = true;
            // 
            // cmnAlquilado
            // 
            this.cmnAlquilado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnAlquilado.HeaderText = "Alquilado";
            this.cmnAlquilado.Name = "cmnAlquilado";
            this.cmnAlquilado.ReadOnly = true;
            // 
            // cmnActivo
            // 
            this.cmnActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnActivo.HeaderText = "Activo";
            this.cmnActivo.Name = "cmnActivo";
            this.cmnActivo.ReadOnly = true;
            // 
            // frmPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsLocalidades);
            this.Name = "frmPeliculas";
            this.Text = "frmPeliculas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tsLocalidades.ResumeLayout(false);
            this.tsLocalidades.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaIncorporacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnAlquilado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnActivo;
        private System.Windows.Forms.ToolStrip tsLocalidades;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
    }
}
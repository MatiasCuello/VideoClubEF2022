
namespace VideoClubEF2022.Windows
{
    partial class frmSocios
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
            this.cmnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSancionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbSocios = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrar = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.tsbSocios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvDatos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.MaximumSize = new System.Drawing.Size(820, 500);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 407);
            this.panel1.TabIndex = 17;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNombre,
            this.cmnApellido,
            this.cmnTipoDoc,
            this.cmnDocumento,
            this.cmnDireccion,
            this.cmnLocalidad,
            this.cmnProvincia,
            this.cmnFechaNac,
            this.cmnActivo,
            this.cmnSancionado});
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDatos.Location = new System.Drawing.Point(0, 0);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersVisible = false;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(804, 407);
            this.dgvDatos.TabIndex = 0;
            // 
            // cmnNombre
            // 
            this.cmnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnNombre.HeaderText = "Nombre";
            this.cmnNombre.Name = "cmnNombre";
            this.cmnNombre.ReadOnly = true;
            // 
            // cmnApellido
            // 
            this.cmnApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnApellido.HeaderText = "Apellido";
            this.cmnApellido.Name = "cmnApellido";
            this.cmnApellido.ReadOnly = true;
            // 
            // cmnTipoDoc
            // 
            this.cmnTipoDoc.HeaderText = "Tipo Doc.";
            this.cmnTipoDoc.Name = "cmnTipoDoc";
            this.cmnTipoDoc.ReadOnly = true;
            // 
            // cmnDocumento
            // 
            this.cmnDocumento.HeaderText = "Documento";
            this.cmnDocumento.Name = "cmnDocumento";
            this.cmnDocumento.ReadOnly = true;
            // 
            // cmnDireccion
            // 
            this.cmnDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDireccion.HeaderText = "Direccion";
            this.cmnDireccion.Name = "cmnDireccion";
            this.cmnDireccion.ReadOnly = true;
            // 
            // cmnLocalidad
            // 
            this.cmnLocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnLocalidad.HeaderText = "Localidad";
            this.cmnLocalidad.Name = "cmnLocalidad";
            this.cmnLocalidad.ReadOnly = true;
            // 
            // cmnProvincia
            // 
            this.cmnProvincia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProvincia.HeaderText = "Provincia";
            this.cmnProvincia.Name = "cmnProvincia";
            this.cmnProvincia.ReadOnly = true;
            // 
            // cmnFechaNac
            // 
            this.cmnFechaNac.HeaderText = "Fecha Nac.";
            this.cmnFechaNac.Name = "cmnFechaNac";
            this.cmnFechaNac.ReadOnly = true;
            // 
            // cmnActivo
            // 
            this.cmnActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnActivo.HeaderText = "Activo";
            this.cmnActivo.Name = "cmnActivo";
            this.cmnActivo.ReadOnly = true;
            // 
            // cmnSancionado
            // 
            this.cmnSancionado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSancionado.HeaderText = "Sancionado";
            this.cmnSancionado.Name = "cmnSancionado";
            this.cmnSancionado.ReadOnly = true;
            // 
            // tsbSocios
            // 
            this.tsbSocios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbBorrar,
            this.tsbCerrar});
            this.tsbSocios.Location = new System.Drawing.Point(0, 0);
            this.tsbSocios.MaximumSize = new System.Drawing.Size(820, 500);
            this.tsbSocios.Name = "tsbSocios";
            this.tsbSocios.Size = new System.Drawing.Size(804, 54);
            this.tsbSocios.TabIndex = 16;
            this.tsbSocios.Text = "toolStrip1";
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
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
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
            this.tsbBorrar.Click += new System.EventHandler(this.tsbBorrar_Click);
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
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // frmSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tsbSocios);
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "frmSocios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSocios";
            this.Load += new System.EventHandler(this.frmSocios_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.tsbSocios.ResumeLayout(false);
            this.tsbSocios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.ToolStrip tsbSocios;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBorrar;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSancionado;
    }
}
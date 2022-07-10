
namespace VideoClubEF2022.Windows
{
    partial class frmProvinciasAE
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
            this.components = new System.ComponentModel.Container();
            this.ProvinciaTextBox = new System.Windows.Forms.TextBox();
            this.lblProvincias = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProvinciaTextBox
            // 
            this.ProvinciaTextBox.Location = new System.Drawing.Point(137, 47);
            this.ProvinciaTextBox.MaxLength = 30;
            this.ProvinciaTextBox.Name = "ProvinciaTextBox";
            this.ProvinciaTextBox.Size = new System.Drawing.Size(280, 20);
            this.ProvinciaTextBox.TabIndex = 36;
            // 
            // lblProvincias
            // 
            this.lblProvincias.AutoSize = true;
            this.lblProvincias.Location = new System.Drawing.Point(67, 50);
            this.lblProvincias.Name = "lblProvincias";
            this.lblProvincias.Size = new System.Drawing.Size(59, 13);
            this.lblProvincias.TabIndex = 39;
            this.lblProvincias.Text = "Provincias:";
            // 
            // CancelButton
            // 
            this.CancelButton.Image = global::VideoClubEF2022.Windows.Properties.Resources.Cancelar;
            this.CancelButton.Location = new System.Drawing.Point(323, 149);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 64);
            this.CancelButton.TabIndex = 38;
            this.CancelButton.Text = "Cancelar";
            this.CancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Image = global::VideoClubEF2022.Windows.Properties.Resources.OK;
            this.OkButton.Location = new System.Drawing.Point(68, 149);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 64);
            this.OkButton.TabIndex = 37;
            this.OkButton.Text = "OK";
            this.OkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProvinciasAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ProvinciaTextBox);
            this.Controls.Add(this.lblProvincias);
            this.MaximumSize = new System.Drawing.Size(500, 300);
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmProvinciasAE";
            this.Text = "frmProvinciasAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox ProvinciaTextBox;
        private System.Windows.Forms.Label lblProvincias;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
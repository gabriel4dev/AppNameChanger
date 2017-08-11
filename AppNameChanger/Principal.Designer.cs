namespace AppNameChanger
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblProceso = new System.Windows.Forms.Label();
            this.txtProcesoId = new System.Windows.Forms.TextBox();
            this.txtNuevoTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grvProcesos = new System.Windows.Forms.DataGridView();
            this.btnVerProcesos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvProcesos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(55, 89);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(321, 38);
            this.btnCambiar.TabIndex = 0;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblProceso
            // 
            this.lblProceso.AutoSize = true;
            this.lblProceso.Location = new System.Drawing.Point(55, 13);
            this.lblProceso.Name = "lblProceso";
            this.lblProceso.Size = new System.Drawing.Size(49, 13);
            this.lblProceso.TabIndex = 1;
            this.lblProceso.Text = "Proceso:";
            // 
            // txtProcesoId
            // 
            this.txtProcesoId.Location = new System.Drawing.Point(126, 13);
            this.txtProcesoId.Name = "txtProcesoId";
            this.txtProcesoId.Size = new System.Drawing.Size(250, 20);
            this.txtProcesoId.TabIndex = 2;
            // 
            // txtNuevoTitulo
            // 
            this.txtNuevoTitulo.Location = new System.Drawing.Point(126, 49);
            this.txtNuevoTitulo.Name = "txtNuevoTitulo";
            this.txtNuevoTitulo.Size = new System.Drawing.Size(250, 20);
            this.txtNuevoTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(58, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo:";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(351, 367);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reestablecer";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grvProcesos
            // 
            this.grvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvProcesos.Location = new System.Drawing.Point(55, 151);
            this.grvProcesos.Name = "grvProcesos";
            this.grvProcesos.Size = new System.Drawing.Size(330, 210);
            this.grvProcesos.TabIndex = 6;
            // 
            // btnVerProcesos
            // 
            this.btnVerProcesos.Location = new System.Drawing.Point(12, 367);
            this.btnVerProcesos.Name = "btnVerProcesos";
            this.btnVerProcesos.Size = new System.Drawing.Size(92, 23);
            this.btnVerProcesos.TabIndex = 7;
            this.btnVerProcesos.Text = "Ver procesos";
            this.btnVerProcesos.UseVisualStyleBackColor = true;
            this.btnVerProcesos.Click += new System.EventHandler(this.btnVerProcesos_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(451, 415);
            this.Controls.Add(this.btnVerProcesos);
            this.Controls.Add(this.grvProcesos);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNuevoTitulo);
            this.Controls.Add(this.txtProcesoId);
            this.Controls.Add(this.lblProceso);
            this.Controls.Add(this.btnCambiar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "App Name Changer v1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grvProcesos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblProceso;
        private System.Windows.Forms.TextBox txtProcesoId;
        private System.Windows.Forms.TextBox txtNuevoTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView grvProcesos;
        private System.Windows.Forms.Button btnVerProcesos;
    }
}


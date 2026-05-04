namespace pryEdRossiT
{
    partial class frmPilas
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
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.lblTramiteRdo = new System.Windows.Forms.Label();
            this.lblNomRdo = new System.Windows.Forms.Label();
            this.lblCodRdo = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblTramit = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNomb = new System.Windows.Forms.Label();
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lstListadoPila = new System.Windows.Forms.ListBox();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbColas = new System.Windows.Forms.PictureBox();
            this.gbEliminado.SuspendLayout();
            this.gbNuevo.SuspendLayout();
            this.gbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.lblTramiteRdo);
            this.gbEliminado.Controls.Add(this.lblNomRdo);
            this.gbEliminado.Controls.Add(this.lblCodRdo);
            this.gbEliminado.Controls.Add(this.lblCod);
            this.gbEliminado.Controls.Add(this.lblTramit);
            this.gbEliminado.Controls.Add(this.btnEliminar);
            this.gbEliminado.Controls.Add(this.lblNomb);
            this.gbEliminado.Location = new System.Drawing.Point(497, 25);
            this.gbEliminado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbEliminado.Size = new System.Drawing.Size(225, 202);
            this.gbEliminado.TabIndex = 16;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Elemento Eliminado";
            // 
            // lblTramiteRdo
            // 
            this.lblTramiteRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramiteRdo.Location = new System.Drawing.Point(89, 111);
            this.lblTramiteRdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramiteRdo.Name = "lblTramiteRdo";
            this.lblTramiteRdo.Size = new System.Drawing.Size(113, 25);
            this.lblTramiteRdo.TabIndex = 5;
            // 
            // lblNomRdo
            // 
            this.lblNomRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNomRdo.Location = new System.Drawing.Point(89, 75);
            this.lblNomRdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomRdo.Name = "lblNomRdo";
            this.lblNomRdo.Size = new System.Drawing.Size(113, 25);
            this.lblNomRdo.TabIndex = 3;
            // 
            // lblCodRdo
            // 
            this.lblCodRdo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodRdo.Location = new System.Drawing.Point(120, 42);
            this.lblCodRdo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodRdo.Name = "lblCodRdo";
            this.lblCodRdo.Size = new System.Drawing.Size(83, 25);
            this.lblCodRdo.TabIndex = 1;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(24, 43);
            this.lblCod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(54, 16);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código:";
            // 
            // lblTramit
            // 
            this.lblTramit.AutoSize = true;
            this.lblTramit.Location = new System.Drawing.Point(24, 112);
            this.lblTramit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramit.Name = "lblTramit";
            this.lblTramit.Size = new System.Drawing.Size(56, 16);
            this.lblTramit.TabIndex = 4;
            this.lblTramit.Text = "Trámite:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 153);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(175, 42);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNomb
            // 
            this.lblNomb.AutoSize = true;
            this.lblNomb.Location = new System.Drawing.Point(24, 75);
            this.lblNomb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomb.Name = "lblNomb";
            this.lblNomb.Size = new System.Drawing.Size(59, 16);
            this.lblNomb.TabIndex = 2;
            this.lblNomb.Text = "Nombre:";
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.txtTramite);
            this.gbNuevo.Controls.Add(this.lblCodigo);
            this.gbNuevo.Controls.Add(this.lblTramite);
            this.gbNuevo.Controls.Add(this.txtCodigo);
            this.gbNuevo.Controls.Add(this.txtNombre);
            this.gbNuevo.Controls.Add(this.btnAgregar);
            this.gbNuevo.Controls.Add(this.lblNombre);
            this.gbNuevo.Location = new System.Drawing.Point(264, 25);
            this.gbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevo.Size = new System.Drawing.Size(225, 202);
            this.gbNuevo.TabIndex = 14;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Nuevo Elemento";
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(89, 112);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(112, 22);
            this.txtTramite.TabIndex = 5;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 43);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(24, 112);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 4;
            this.lblTramite.Text = "Tramite:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(120, 34);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 71);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 153);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 42);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 76);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstListadoPila);
            this.gbListado.Controls.Add(this.dgvPila);
            this.gbListado.Location = new System.Drawing.Point(12, 234);
            this.gbListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbListado.Size = new System.Drawing.Size(711, 251);
            this.gbListado.TabIndex = 17;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListadoPila
            // 
            this.lstListadoPila.FormattingEnabled = true;
            this.lstListadoPila.ItemHeight = 16;
            this.lstListadoPila.Location = new System.Drawing.Point(21, 23);
            this.lstListadoPila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListadoPila.Name = "lstListadoPila";
            this.lstListadoPila.Size = new System.Drawing.Size(208, 196);
            this.lstListadoPila.TabIndex = 1;
            // 
            // dgvPila
            // 
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda});
            this.dgvPila.Location = new System.Drawing.Point(252, 26);
            this.dgvPila.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.RowHeadersVisible = false;
            this.dgvPila.RowHeadersWidth = 51;
            this.dgvPila.Size = new System.Drawing.Size(417, 194);
            this.dgvPila.TabIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colDeuda
            // 
            this.colDeuda.Frozen = true;
            this.colDeuda.HeaderText = "Trámite";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.Width = 125;
            // 
            // pbColas
            // 
            this.pbColas.Image = global::pryEdRossiT.Properties.Resources.pila;
            this.pbColas.Location = new System.Drawing.Point(33, 26);
            this.pbColas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(209, 180);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 15;
            this.pbColas.TabStop = false;
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 502);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.gbNuevo);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.pbColas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPilas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de datos: PILA";
            this.Load += new System.EventHandler(this.frmPilas_Load);
            this.gbEliminado.ResumeLayout(false);
            this.gbEliminado.PerformLayout();
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            this.gbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Label lblTramiteRdo;
        private System.Windows.Forms.Label lblNomRdo;
        private System.Windows.Forms.Label lblCodRdo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblTramit;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNomb;
        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.ListBox lstListadoPila;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.PictureBox pbColas;
    }
}
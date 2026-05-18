namespace pryEdRossiT
{
    partial class frmGrafos
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
            this.gbNuevo = new System.Windows.Forms.GroupBox();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblDestino = new System.Windows.Forms.Label();
            this.pbColas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRdoPrecio = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblOrigenCta = new System.Windows.Forms.Label();
            this.lblPrecioCta = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lblDestinoCta = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnViajes = new System.Windows.Forms.Button();
            this.btnOrigenes = new System.Windows.Forms.Button();
            this.btnDestinos = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.cmbHasta = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.cmbDesde = new System.Windows.Forms.ComboBox();
            this.dgvGrafos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSantaFe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbNuevo
            // 
            this.gbNuevo.Controls.Add(this.cmbOrigen);
            this.gbNuevo.Controls.Add(this.cmbDestino);
            this.gbNuevo.Controls.Add(this.btnCargar);
            this.gbNuevo.Controls.Add(this.txtPrecio);
            this.gbNuevo.Controls.Add(this.lblOrigen);
            this.gbNuevo.Controls.Add(this.lblPrecio);
            this.gbNuevo.Controls.Add(this.btnBorrar);
            this.gbNuevo.Controls.Add(this.lblDestino);
            this.gbNuevo.Location = new System.Drawing.Point(268, 12);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Size = new System.Drawing.Size(194, 160);
            this.gbNuevo.TabIndex = 4;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Carga de Datos:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(67, 28);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(119, 21);
            this.cmbOrigen.TabIndex = 9;
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(67, 60);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(119, 21);
            this.cmbDestino.TabIndex = 8;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(106, 127);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(80, 27);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(67, 92);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(119, 20);
            this.txtPrecio.TabIndex = 5;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(9, 28);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(47, 15);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(11, 93);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(45, 15);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 127);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(80, 27);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar Todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(9, 61);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(52, 15);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            // 
            // pbColas
            // 
            this.pbColas.Image = global::pryEdRossiT.Properties.Resources.images;
            this.pbColas.Location = new System.Drawing.Point(12, 12);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(239, 160);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 5;
            this.pbColas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRdoPrecio);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.lblOrigenCta);
            this.groupBox1.Controls.Add(this.lblPrecioCta);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.lblDestinoCta);
            this.groupBox1.Location = new System.Drawing.Point(468, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 160);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Datos:";
            // 
            // lblRdoPrecio
            // 
            this.lblRdoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRdoPrecio.Location = new System.Drawing.Point(67, 92);
            this.lblRdoPrecio.Name = "lblRdoPrecio";
            this.lblRdoPrecio.Size = new System.Drawing.Size(119, 20);
            this.lblRdoPrecio.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(119, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 60);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(119, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(106, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 27);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lblOrigenCta
            // 
            this.lblOrigenCta.AutoSize = true;
            this.lblOrigenCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenCta.Location = new System.Drawing.Point(9, 28);
            this.lblOrigenCta.Name = "lblOrigenCta";
            this.lblOrigenCta.Size = new System.Drawing.Size(47, 15);
            this.lblOrigenCta.TabIndex = 0;
            this.lblOrigenCta.Text = "Origen:";
            // 
            // lblPrecioCta
            // 
            this.lblPrecioCta.AutoSize = true;
            this.lblPrecioCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCta.Location = new System.Drawing.Point(11, 93);
            this.lblPrecioCta.Name = "lblPrecioCta";
            this.lblPrecioCta.Size = new System.Drawing.Size(45, 15);
            this.lblPrecioCta.TabIndex = 4;
            this.lblPrecioCta.Text = "Precio:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(12, 127);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(80, 27);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // lblDestinoCta
            // 
            this.lblDestinoCta.AutoSize = true;
            this.lblDestinoCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoCta.Location = new System.Drawing.Point(9, 61);
            this.lblDestinoCta.Name = "lblDestinoCta";
            this.lblDestinoCta.Size = new System.Drawing.Size(52, 15);
            this.lblDestinoCta.TabIndex = 2;
            this.lblDestinoCta.Text = "Destino:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnViajes);
            this.groupBox2.Controls.Add(this.btnOrigenes);
            this.groupBox2.Controls.Add(this.btnDestinos);
            this.groupBox2.Controls.Add(this.lblHasta);
            this.groupBox2.Controls.Add(this.cmbHasta);
            this.groupBox2.Controls.Add(this.lblDesde);
            this.groupBox2.Controls.Add(this.cmbDesde);
            this.groupBox2.Controls.Add(this.dgvGrafos);
            this.groupBox2.Location = new System.Drawing.Point(14, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 208);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar Viajes";
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(552, 19);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(86, 27);
            this.btnViajes.TabIndex = 15;
            this.btnViajes.Text = "Ver Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            // 
            // btnOrigenes
            // 
            this.btnOrigenes.Location = new System.Drawing.Point(460, 19);
            this.btnOrigenes.Name = "btnOrigenes";
            this.btnOrigenes.Size = new System.Drawing.Size(86, 27);
            this.btnOrigenes.TabIndex = 14;
            this.btnOrigenes.Text = "Listar Origenes";
            this.btnOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(182, 16);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(86, 27);
            this.btnDestinos.TabIndex = 10;
            this.btnDestinos.Text = "Listar Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(281, 21);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(42, 15);
            this.lblHasta.TabIndex = 12;
            this.lblHasta.Text = "Hasta:";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(329, 20);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(119, 21);
            this.cmbHasta.TabIndex = 13;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(6, 20);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(46, 15);
            this.lblDesde.TabIndex = 10;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(57, 19);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(119, 21);
            this.cmbDesde.TabIndex = 11;
            // 
            // dgvGrafos
            // 
            this.dgvGrafos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colDeuda,
            this.colSantaFe,
            this.colBS});
            this.dgvGrafos.Location = new System.Drawing.Point(9, 61);
            this.dgvGrafos.Name = "dgvGrafos";
            this.dgvGrafos.RowHeadersVisible = false;
            this.dgvGrafos.RowHeadersWidth = 51;
            this.dgvGrafos.Size = new System.Drawing.Size(618, 127);
            this.dgvGrafos.TabIndex = 8;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Origen";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Córdoba";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colDeuda
            // 
            this.colDeuda.Frozen = true;
            this.colDeuda.HeaderText = "Mendoza";
            this.colDeuda.MinimumWidth = 6;
            this.colDeuda.Name = "colDeuda";
            this.colDeuda.Width = 125;
            // 
            // colSantaFe
            // 
            this.colSantaFe.HeaderText = "Santa Fé";
            this.colSantaFe.Name = "colSantaFe";
            // 
            // colBS
            // 
            this.colBS.HeaderText = "Buenos Aires";
            this.colBS.Name = "colBS";
            // 
            // frmGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbColas);
            this.Controls.Add(this.gbNuevo);
            this.Name = "frmGrafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas-Grafos";
            this.gbNuevo.ResumeLayout(false);
            this.gbNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.PictureBox pbColas;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblOrigenCta;
        private System.Windows.Forms.Label lblPrecioCta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label lblDestinoCta;
        private System.Windows.Forms.Label lblRdoPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnViajes;
        private System.Windows.Forms.Button btnOrigenes;
        private System.Windows.Forms.Button btnDestinos;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.ComboBox cmbHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ComboBox cmbDesde;
        private System.Windows.Forms.DataGridView dgvGrafos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSantaFe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBS;
    }
}
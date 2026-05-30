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
            this.cmbOrigenCta = new System.Windows.Forms.ComboBox();
            this.cmbDestinoCta = new System.Windows.Forms.ComboBox();
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
            this.gbNuevo.Location = new System.Drawing.Point(357, 15);
            this.gbNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevo.Name = "gbNuevo";
            this.gbNuevo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNuevo.Size = new System.Drawing.Size(259, 197);
            this.gbNuevo.TabIndex = 0;
            this.gbNuevo.TabStop = false;
            this.gbNuevo.Text = "Carga de Datos:";
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Location = new System.Drawing.Point(89, 34);
            this.cmbOrigen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(157, 24);
            this.cmbOrigen.TabIndex = 1;
            this.cmbOrigen.SelectedIndexChanged += new System.EventHandler(this.cmbOrigen_SelectedIndexChanged);
            // 
            // cmbDestino
            // 
            this.cmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(89, 74);
            this.cmbDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(157, 24);
            this.cmbDestino.TabIndex = 3;
            this.cmbDestino.SelectedIndexChanged += new System.EventHandler(this.cmbDestino_SelectedIndexChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(141, 156);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(107, 33);
            this.btnCargar.TabIndex = 7;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(89, 113);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 22);
            this.txtPrecio.TabIndex = 5;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigen.Location = new System.Drawing.Point(12, 34);
            this.lblOrigen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(56, 18);
            this.lblOrigen.TabIndex = 0;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(15, 114);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(16, 156);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 33);
            this.btnBorrar.TabIndex = 6;
            this.btnBorrar.Text = "Borrar Todo";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestino.Location = new System.Drawing.Point(12, 75);
            this.lblDestino.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(63, 18);
            this.lblDestino.TabIndex = 2;
            this.lblDestino.Text = "Destino:";
            // 
            // pbColas
            // 
            this.pbColas.Image = global::pryEdRossiT.Properties.Resources.images;
            this.pbColas.Location = new System.Drawing.Point(16, 15);
            this.pbColas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbColas.Name = "pbColas";
            this.pbColas.Size = new System.Drawing.Size(319, 197);
            this.pbColas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbColas.TabIndex = 5;
            this.pbColas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRdoPrecio);
            this.groupBox1.Controls.Add(this.cmbOrigenCta);
            this.groupBox1.Controls.Add(this.cmbDestinoCta);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.lblOrigenCta);
            this.groupBox1.Controls.Add(this.lblPrecioCta);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Controls.Add(this.lblDestinoCta);
            this.groupBox1.Location = new System.Drawing.Point(624, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(259, 197);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consulta de Datos:";
            // 
            // lblRdoPrecio
            // 
            this.lblRdoPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRdoPrecio.Location = new System.Drawing.Point(89, 113);
            this.lblRdoPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRdoPrecio.Name = "lblRdoPrecio";
            this.lblRdoPrecio.Size = new System.Drawing.Size(159, 25);
            this.lblRdoPrecio.TabIndex = 5;
            // 
            // cmbOrigenCta
            // 
            this.cmbOrigenCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrigenCta.FormattingEnabled = true;
            this.cmbOrigenCta.Location = new System.Drawing.Point(89, 34);
            this.cmbOrigenCta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOrigenCta.Name = "cmbOrigenCta";
            this.cmbOrigenCta.Size = new System.Drawing.Size(157, 24);
            this.cmbOrigenCta.TabIndex = 1;
            this.cmbOrigenCta.SelectedIndexChanged += new System.EventHandler(this.cmbOrigenCta_SelectedIndexChanged);
            // 
            // cmbDestinoCta
            // 
            this.cmbDestinoCta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestinoCta.FormattingEnabled = true;
            this.cmbDestinoCta.Location = new System.Drawing.Point(89, 74);
            this.cmbDestinoCta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDestinoCta.Name = "cmbDestinoCta";
            this.cmbDestinoCta.Size = new System.Drawing.Size(157, 24);
            this.cmbDestinoCta.TabIndex = 3;
            this.cmbDestinoCta.SelectedIndexChanged += new System.EventHandler(this.cmbDestinoCta_SelectedIndexChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(141, 156);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(107, 33);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Borrar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblOrigenCta
            // 
            this.lblOrigenCta.AutoSize = true;
            this.lblOrigenCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrigenCta.Location = new System.Drawing.Point(12, 34);
            this.lblOrigenCta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigenCta.Name = "lblOrigenCta";
            this.lblOrigenCta.Size = new System.Drawing.Size(56, 18);
            this.lblOrigenCta.TabIndex = 0;
            this.lblOrigenCta.Text = "Origen:";
            // 
            // lblPrecioCta
            // 
            this.lblPrecioCta.AutoSize = true;
            this.lblPrecioCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioCta.Location = new System.Drawing.Point(15, 114);
            this.lblPrecioCta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioCta.Name = "lblPrecioCta";
            this.lblPrecioCta.Size = new System.Drawing.Size(55, 18);
            this.lblPrecioCta.TabIndex = 4;
            this.lblPrecioCta.Text = "Precio:";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(16, 156);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(107, 33);
            this.btnConsulta.TabIndex = 6;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lblDestinoCta
            // 
            this.lblDestinoCta.AutoSize = true;
            this.lblDestinoCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDestinoCta.Location = new System.Drawing.Point(12, 75);
            this.lblDestinoCta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestinoCta.Name = "lblDestinoCta";
            this.lblDestinoCta.Size = new System.Drawing.Size(63, 18);
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
            this.groupBox2.Location = new System.Drawing.Point(19, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(864, 256);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar Viajes";
            // 
            // btnViajes
            // 
            this.btnViajes.Location = new System.Drawing.Point(736, 23);
            this.btnViajes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViajes.Name = "btnViajes";
            this.btnViajes.Size = new System.Drawing.Size(115, 33);
            this.btnViajes.TabIndex = 6;
            this.btnViajes.Text = "Ver Viajes";
            this.btnViajes.UseVisualStyleBackColor = true;
            this.btnViajes.Click += new System.EventHandler(this.btnViajes_Click);
            // 
            // btnOrigenes
            // 
            this.btnOrigenes.Location = new System.Drawing.Point(613, 23);
            this.btnOrigenes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrigenes.Name = "btnOrigenes";
            this.btnOrigenes.Size = new System.Drawing.Size(115, 33);
            this.btnOrigenes.TabIndex = 5;
            this.btnOrigenes.Text = "Listar Origenes";
            this.btnOrigenes.UseVisualStyleBackColor = true;
            this.btnOrigenes.Click += new System.EventHandler(this.btnOrigenes_Click);
            // 
            // btnDestinos
            // 
            this.btnDestinos.Location = new System.Drawing.Point(243, 20);
            this.btnDestinos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDestinos.Name = "btnDestinos";
            this.btnDestinos.Size = new System.Drawing.Size(115, 33);
            this.btnDestinos.TabIndex = 2;
            this.btnDestinos.Text = "Listar Destinos";
            this.btnDestinos.UseVisualStyleBackColor = true;
            this.btnDestinos.Click += new System.EventHandler(this.btnDestinos_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(375, 26);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(51, 18);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // cmbHasta
            // 
            this.cmbHasta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHasta.FormattingEnabled = true;
            this.cmbHasta.Location = new System.Drawing.Point(439, 25);
            this.cmbHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbHasta.Name = "cmbHasta";
            this.cmbHasta.Size = new System.Drawing.Size(157, 24);
            this.cmbHasta.TabIndex = 4;
            this.cmbHasta.SelectedIndexChanged += new System.EventHandler(this.cmbHasta_SelectedIndexChanged);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(8, 25);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(55, 18);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // cmbDesde
            // 
            this.cmbDesde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesde.FormattingEnabled = true;
            this.cmbDesde.Location = new System.Drawing.Point(76, 23);
            this.cmbDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDesde.Name = "cmbDesde";
            this.cmbDesde.Size = new System.Drawing.Size(157, 24);
            this.cmbDesde.TabIndex = 1;
            this.cmbDesde.SelectedIndexChanged += new System.EventHandler(this.cmbDesde_SelectedIndexChanged);
            // 
            // dgvGrafos
            // 
            this.dgvGrafos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafos.Location = new System.Drawing.Point(12, 75);
            this.dgvGrafos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvGrafos.Name = "dgvGrafos";
            this.dgvGrafos.RowHeadersVisible = false;
            this.dgvGrafos.RowHeadersWidth = 51;
            this.dgvGrafos.Size = new System.Drawing.Size(824, 156);
            this.dgvGrafos.TabIndex = 7;
            // 
            // frmGrafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 503);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbColas);
            this.Controls.Add(this.gbNuevo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGrafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas-Grafos";
            this.Load += new System.EventHandler(this.frmGrafos_Load);
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
        private System.Windows.Forms.ComboBox cmbOrigenCta;
        private System.Windows.Forms.ComboBox cmbDestinoCta;
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
    }
}
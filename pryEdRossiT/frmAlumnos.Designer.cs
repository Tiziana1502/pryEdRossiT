namespace pryEdRossiT
{
    partial class frmAlumnos
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
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarreras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCarreras});
            this.dgvAlumnos.Location = new System.Drawing.Point(22, 174);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.Size = new System.Drawing.Size(346, 132);
            this.dgvAlumnos.TabIndex = 19;
            // 
            // colCodigo
            // 
            this.colCodigo.Frozen = true;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.MinimumWidth = 6;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 125;
            // 
            // colNombre
            // 
            this.colNombre.Frozen = true;
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 6;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 125;
            // 
            // colCarreras
            // 
            this.colCarreras.Frozen = true;
            this.colCarreras.HeaderText = "Carreras";
            this.colCarreras.MinimumWidth = 6;
            this.colCarreras.Name = "colCarreras";
            this.colCarreras.Width = 125;
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(19, 87);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(44, 13);
            this.lblCarrera.TabIndex = 18;
            this.lblCarrera.Text = "Carrera:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(73, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(247, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(122, 20);
            this.txtCodigo.TabIndex = 14;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(19, 23);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 13;
            this.lblCodigo.Text = "Código:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(271, 129);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(98, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(73, 84);
            this.cmbCarrera.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(296, 21);
            this.cmbCarrera.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(149, 129);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 23);
            this.btnLimpiar.TabIndex = 21;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 318);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnGrabar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.frmAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarreras;
        private System.Windows.Forms.Button btnLimpiar;
    }
}
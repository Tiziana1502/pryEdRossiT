namespace pryEdRossiT
{
    partial class frmBdConsultaTablas
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
            this.dgvTablaCta = new System.Windows.Forms.DataGridView();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTablaCta
            // 
            this.dgvTablaCta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaCta.Location = new System.Drawing.Point(13, 22);
            this.dgvTablaCta.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTablaCta.Name = "dgvTablaCta";
            this.dgvTablaCta.RowHeadersVisible = false;
            this.dgvTablaCta.RowHeadersWidth = 51;
            this.dgvTablaCta.Size = new System.Drawing.Size(816, 324);
            this.dgvTablaCta.TabIndex = 1;
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Items.AddRange(new object[] {
            "Autor",
            "Idioma",
            "Libro",
            "Pais"});
            this.cmbTabla.Location = new System.Drawing.Point(523, 369);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(193, 28);
            this.cmbTabla.TabIndex = 10;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(263, 369);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(243, 25);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Tabla de la base de datos:";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(724, 365);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 34);
            this.btnListar.TabIndex = 9;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmBdConsultaTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 437);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvTablaCta);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBdConsultaTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de una tabla";
            this.Load += new System.EventHandler(this.frmBdConsultaTablas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaCta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTablaCta;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnListar;
    }
}
namespace pryEdRossiT
{
    partial class frmBdRepaso
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.dgvRepaso = new System.Windows.Forms.DataGridView();
            this.cmbTabla = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatos
            // 
            this.lblDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(13, 73);
            this.lblDatos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(816, 94);
            this.lblDatos.TabIndex = 20;
            // 
            // dgvRepaso
            // 
            this.dgvRepaso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepaso.Location = new System.Drawing.Point(13, 192);
            this.dgvRepaso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRepaso.Name = "dgvRepaso";
            this.dgvRepaso.RowHeadersVisible = false;
            this.dgvRepaso.RowHeadersWidth = 51;
            this.dgvRepaso.Size = new System.Drawing.Size(816, 332);
            this.dgvRepaso.TabIndex = 19;
            // 
            // cmbTabla
            // 
            this.cmbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTabla.FormattingEnabled = true;
            this.cmbTabla.Location = new System.Drawing.Point(377, 21);
            this.cmbTabla.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTabla.Name = "cmbTabla";
            this.cmbTabla.Size = new System.Drawing.Size(339, 28);
            this.cmbTabla.TabIndex = 18;
            this.cmbTabla.SelectedIndexChanged += new System.EventHandler(this.cmbTabla_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(9, 22);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 22);
            this.lblTitulo.TabIndex = 16;
            this.lblTitulo.Text = "Operación a realizar en la base de datos:";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(724, 17);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 34);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmBdRepaso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 554);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.dgvRepaso);
            this.Controls.Add(this.cmbTabla);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBdRepaso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repaso de Operaciones de Base de Datos";
            this.Load += new System.EventHandler(this.frmBdRepaso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepaso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView dgvRepaso;
        private System.Windows.Forms.ComboBox cmbTabla;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnListar;
    }
}
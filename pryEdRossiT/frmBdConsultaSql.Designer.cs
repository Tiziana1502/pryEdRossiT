namespace pryEdRossiT
{
    partial class frmBdConsultaSql
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
            this.dgvCtaSql = new System.Windows.Forms.DataGridView();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCtaSql
            // 
            this.dgvCtaSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtaSql.Location = new System.Drawing.Point(13, 284);
            this.dgvCtaSql.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCtaSql.Name = "dgvCtaSql";
            this.dgvCtaSql.RowHeadersVisible = false;
            this.dgvCtaSql.RowHeadersWidth = 51;
            this.dgvCtaSql.Size = new System.Drawing.Size(816, 239);
            this.dgvCtaSql.TabIndex = 11;
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(13, 59);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(816, 168);
            this.txtSQL.TabIndex = 16;
            this.txtSQL.TextChanged += new System.EventHandler(this.txtSQL_TextChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(13, 27);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(216, 29);
            this.lblConsulta.TabIndex = 15;
            this.lblConsulta.Text = "Consulta en SQL:";
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(724, 234);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(105, 34);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // frmBdConsultaSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 554);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.lblConsulta);
            this.Controls.Add(this.dgvCtaSql);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBdConsultaSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas en la Base de Datos";
            this.Load += new System.EventHandler(this.frmBdConsultaSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtaSql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCtaSql;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnListar;
    }
}
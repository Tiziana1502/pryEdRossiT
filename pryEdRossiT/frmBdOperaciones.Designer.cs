namespace pryEdRossiT
{
    partial class frmBdOperaciones
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
            this.dgvOperac = new System.Windows.Forms.DataGridView();
            this.gbEliminado = new System.Windows.Forms.GroupBox();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.btnProMultiAtributo = new System.Windows.Forms.Button();
            this.btnProSimple = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.btnSelMultiAtributo = new System.Windows.Forms.Button();
            this.btnSelSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperac)).BeginInit();
            this.gbEliminado.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperac
            // 
            this.dgvOperac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperac.Location = new System.Drawing.Point(13, 22);
            this.dgvOperac.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOperac.Name = "dgvOperac";
            this.dgvOperac.RowHeadersVisible = false;
            this.dgvOperac.RowHeadersWidth = 51;
            this.dgvOperac.Size = new System.Drawing.Size(816, 303);
            this.dgvOperac.TabIndex = 20;
            // 
            // gbEliminado
            // 
            this.gbEliminado.Controls.Add(this.btnJuntar);
            this.gbEliminado.Controls.Add(this.btnProMultiAtributo);
            this.gbEliminado.Controls.Add(this.btnProSimple);
            this.gbEliminado.Location = new System.Drawing.Point(13, 333);
            this.gbEliminado.Margin = new System.Windows.Forms.Padding(4);
            this.gbEliminado.Name = "gbEliminado";
            this.gbEliminado.Padding = new System.Windows.Forms.Padding(4);
            this.gbEliminado.Size = new System.Drawing.Size(270, 179);
            this.gbEliminado.TabIndex = 21;
            this.gbEliminado.TabStop = false;
            this.gbEliminado.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(17, 128);
            this.btnJuntar.Margin = new System.Windows.Forms.Padding(4);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(225, 26);
            this.btnJuntar.TabIndex = 10;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // btnProMultiAtributo
            // 
            this.btnProMultiAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProMultiAtributo.Location = new System.Drawing.Point(17, 83);
            this.btnProMultiAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.btnProMultiAtributo.Name = "btnProMultiAtributo";
            this.btnProMultiAtributo.Size = new System.Drawing.Size(225, 26);
            this.btnProMultiAtributo.TabIndex = 9;
            this.btnProMultiAtributo.Text = "Proyección Multiatributo";
            this.btnProMultiAtributo.UseVisualStyleBackColor = true;
            // 
            // btnProSimple
            // 
            this.btnProSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProSimple.Location = new System.Drawing.Point(17, 36);
            this.btnProSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnProSimple.Name = "btnProSimple";
            this.btnProSimple.Size = new System.Drawing.Size(225, 26);
            this.btnProSimple.TabIndex = 6;
            this.btnProSimple.Text = "Proyección Simple";
            this.btnProSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConvolucion);
            this.groupBox1.Controls.Add(this.btnSelMultiAtributo);
            this.groupBox1.Controls.Add(this.btnSelSimple);
            this.groupBox1.Location = new System.Drawing.Point(303, 333);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(271, 179);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Selección - WHERE";
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvolucion.Location = new System.Drawing.Point(21, 128);
            this.btnConvolucion.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(225, 26);
            this.btnConvolucion.TabIndex = 10;
            this.btnConvolucion.Text = "Selección por convolución";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // btnSelMultiAtributo
            // 
            this.btnSelMultiAtributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelMultiAtributo.Location = new System.Drawing.Point(21, 83);
            this.btnSelMultiAtributo.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelMultiAtributo.Name = "btnSelMultiAtributo";
            this.btnSelMultiAtributo.Size = new System.Drawing.Size(225, 26);
            this.btnSelMultiAtributo.TabIndex = 9;
            this.btnSelMultiAtributo.Text = "Selección Multiatributo";
            this.btnSelMultiAtributo.UseVisualStyleBackColor = true;
            // 
            // btnSelSimple
            // 
            this.btnSelSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelSimple.Location = new System.Drawing.Point(21, 36);
            this.btnSelSimple.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelSimple.Name = "btnSelSimple";
            this.btnSelSimple.Size = new System.Drawing.Size(225, 26);
            this.btnSelSimple.TabIndex = 6;
            this.btnSelSimple.Text = "Selección Simple";
            this.btnSelSimple.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDiferencia);
            this.groupBox2.Controls.Add(this.btnInterseccion);
            this.groupBox2.Controls.Add(this.btnUnion);
            this.groupBox2.Location = new System.Drawing.Point(582, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(247, 179);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiferencia.Location = new System.Drawing.Point(8, 128);
            this.btnDiferencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(225, 26);
            this.btnDiferencia.TabIndex = 10;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterseccion.Location = new System.Drawing.Point(8, 83);
            this.btnInterseccion.Margin = new System.Windows.Forms.Padding(4);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(225, 26);
            this.btnInterseccion.TabIndex = 9;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnion.Location = new System.Drawing.Point(8, 36);
            this.btnUnion.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(225, 26);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmBdOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 537);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbEliminado);
            this.Controls.Add(this.dgvOperac);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBdOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperac)).EndInit();
            this.gbEliminado.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperac;
        private System.Windows.Forms.GroupBox gbEliminado;
        private System.Windows.Forms.Button btnProSimple;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProMultiAtributo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button btnSelMultiAtributo;
        private System.Windows.Forms.Button btnSelSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}
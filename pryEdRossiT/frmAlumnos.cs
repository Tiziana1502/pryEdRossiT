using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryEdRossiT
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            clsArchivo objGrabar = new clsArchivo();
            objGrabar.NombreArc = "Carreras.csv";
            objGrabar.Recorrer(cmbCarrera);

            clsArchivo objAlumnos = new clsArchivo();
            if (File.Exists(objAlumnos.NombreArc)) objAlumnos.Recorrer(dgvAlumnos);
            btnGrabar.Enabled = false;

        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "")
            {
                btnGrabar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objRecorrer = new clsArchivo();
            objRecorrer.NombreArc = "Alumnos.csv";
            objRecorrer.Grabar(txtCodigo.Text, txtNombre.Text, cmbCarrera.Text);
            objRecorrer.Recorrer(dgvAlumnos);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Alumnos.csv");
            x.LimpiarTodo();           

            txtCodigo.Text = "";
            txtNombre.Text = "";
            cmbCarrera.Text = "";
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}

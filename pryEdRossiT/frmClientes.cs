using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace pryEdRossiT
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo objRecorrer = new clsArchivo();
            objRecorrer.NombreArc = "Clientes.csv";
            objRecorrer.Grabar(txtCodigo.Text, txtNombre.Text, txtDeuda.Text);
            objRecorrer.Recorrer(dgvClientes);

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = "Clientes.csv";
            if (File.Exists(x.NombreArc)) x.Recorrer(dgvClientes);
            btnGrabar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {            
            clsArchivo x = new clsArchivo();
            x.NombreArc = ("Clientes.csv");
            x.LimpiarTodo();
            //x.Recorrer();

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDeuda.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void txtDeuda_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }
    }
}

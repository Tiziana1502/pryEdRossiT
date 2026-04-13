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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text != "" && txtDeuda.Text != "")
            {
                btnGrabar.Enabled = false;
            }
            else
            {
                btnGrabar.Enabled = true;
            }
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
    }
}

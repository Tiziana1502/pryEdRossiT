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
    public partial class frmPilas : Form
    {
        public frmPilas()
        {
            InitializeComponent();
        }
        clsPila objPila = new clsPila();

        private void frmPilas_Load(object sender, EventArgs e)
        {
            clsArchivo x = new clsArchivo();
            x.NombreArc = "Pila.csv";
            if (File.Exists(x.NombreArc)) x.Recorrer(dgvPila);           
            btnAgregar.Enabled = false;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objPila.Agregar(x);
            objPila.Recorrer(dgvPila);
            //Esto no es necesario pero se hrealiza para ver si funciona el programa y el método
            objPila.Recorrer("Pila.csv");
            objPila.Recorrer(lstListadoPila);

            //Limpio los controles
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblCodRdo.Text = objPila.Primero.Codigo.ToString();
                lblNomRdo.Text = objPila.Primero.Nombre;
                lblTramiteRdo.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvPila);
                objPila.Recorrer("Pila.csv");
                objPila.Recorrer(lstListadoPila);
            }
            else
            {
                lblCodRdo.Text = "";
                lblNomRdo.Text = "";
                lblTramiteRdo.Text = "";
            }
        }
    }
}

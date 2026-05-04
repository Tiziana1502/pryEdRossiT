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
                     
            btnAgregar.Enabled = false;
        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                btnAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
           ValidarDatos();
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

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
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
    }
}

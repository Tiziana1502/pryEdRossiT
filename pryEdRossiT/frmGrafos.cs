using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdRossiT
{
    public partial class frmGrafos : Form
    {
        public frmGrafos()
        {
            InitializeComponent();
        }

        clsGrafos objGrafo = new clsGrafos();   

        private void frmGrafos_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cmbOrigen);
            objGrafo.MostrarCiudades(cmbDestino);
            objGrafo.MostrarCiudades(cmbDesde);
            objGrafo.MostrarCiudades(cmbHasta);
            objGrafo.MostrarCiudades(cmbOrigenCta);
            objGrafo.MostrarCiudades(cmbDestinoCta);
        }

        private void Limpiar()
        {
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void ValidarDatos()
        {
            if (cmbOrigen.Text != "" && cmbOrigenCta.Text != "" && 
                cmbDestino.Text != "" && cmbDestinoCta.Text != "" && txtPrecio.Text != "")
            {
                btnCargar.Enabled = true;
                btnConsulta.Enabled=true;
                btnBorrar.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            else
            {
                btnCargar.Enabled = false;
                btnConsulta.Enabled = true;
                btnBorrar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite números (char.IsDigit) y la tecla de borrar (char.IsControl)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquea cualquier otro caracter
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           Int32 f = cmbOrigenCta.SelectedIndex;
           Int32 c = cmbDestinoCta.SelectedIndex;
           objGrafo.Eliminar(f, c);
           cmbOrigenCta.SelectedIndex = -1;
           cmbDestinoCta.SelectedIndex = -1;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigen.SelectedIndex;
            Int32 c = cmbDestino.SelectedIndex;
            Decimal p = Convert.ToDecimal(txtPrecio.Text);
            objGrafo.Agregar(f,c,p);
            objGrafo.MostrarTodo(dgvGrafos);
            Limpiar();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Int32 f = cmbOrigenCta.SelectedIndex;
            Int32 c = cmbDestinoCta.SelectedIndex;
            lblRdoPrecio.Text = Convert.ToString(objGrafo.Consultar(f, c));
        }

        private void btnDestinos_Click(object sender, EventArgs e)
        {
            Int32 f = cmbDesde.SelectedIndex;
            objGrafo.MostrarDestinos(f, dgvGrafos);
        }

        private void btnOrigenes_Click(object sender, EventArgs e)
        {
            Int32 c= cmbHasta.SelectedIndex;
            objGrafo.MostrarOrigenes(c, dgvGrafos);
        }

        private void btnViajes_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dgvGrafos);
        }
    }
}

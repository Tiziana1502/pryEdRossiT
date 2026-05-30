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

            btnConsulta.Enabled = false;
            btnLimpiar.Enabled = false;
            btnDestinos.Enabled = false;
            btnOrigenes.Enabled = false;
            btnViajes.Enabled = false;
        }

        private void Limpiar()
        {
            cmbOrigen.SelectedIndex = -1;
            cmbDestino.SelectedIndex = -1;
            txtPrecio.Text = "";
        }

        private void ValidarDatos()
        {
            if (cmbOrigen.Text != "" && cmbDestino.Text != "" && txtPrecio.Text != "")              
            {
                btnCargar.Enabled = true;              
                btnBorrar.Enabled = true;               
            }
            else
            {
                btnCargar.Enabled = false;           
                btnBorrar.Enabled = false;             
            }
        }
        private void Validacion()
        {
            if (cmbOrigenCta.Text != "" && cmbDestinoCta.Text != "")
            {
                btnConsulta.Enabled = true;
                btnLimpiar.Enabled = true;
            }
            else
            {
                btnConsulta.Enabled = false;
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
           lblRdoPrecio.Text = "";
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

        private void cmbOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmbOrigenCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDestinoCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validacion();
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDesde.SelectedIndex != -1) btnDestinos.Enabled = true;
            else btnDestinos.Enabled = false;
            
        }

        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHasta.SelectedIndex != -1)
            {
                btnOrigenes.Enabled = true;
                btnViajes.Enabled = true;
            }
            else
            {
                btnOrigenes.Enabled = false;
                btnOrigenes.Enabled = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void frmGrafos_Load(object sender, EventArgs e)
        {
            btnCargar.Enabled = false;
            btnConsulta.Enabled = false;
            btnBorrar.Enabled = false;
            btnLimpiar.Enabled = false;
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
        
    }
}

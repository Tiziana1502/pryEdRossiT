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
    public partial class frmBdConsultaTablas : Form
    {
        public frmBdConsultaTablas()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clsBaseDatos bd = new clsBaseDatos();
            bd.Listar(cmbTabla.Text, dgvTablaCta);
        }

        private void frmBdConsultaTablas_Load(object sender, EventArgs e)
        {
            btnListar.Enabled = false;
        }

        private void cmbTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTabla.SelectedIndex != -1) btnListar.Enabled = true;
            else btnListar.Enabled = false;
        }
    }
}

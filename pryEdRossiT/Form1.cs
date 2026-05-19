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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosDelDesarrollador vent = new frmDatosDelDesarrollador();
            vent.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses ven = new frmMeses();
            ven.ShowDialog();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores ven = new frmColores();
            ven.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes ven = new frmClientes();
            ven.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos ven = new frmAlumnos();
            ven.ShowDialog();

        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarreras ven = new frmCarreras();
            ven.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas ven = new frmColas();
            ven.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas ven = new frmPilas();
            ven.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple ven = new frmListaSimple();
            ven.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble ven = new frmListaDoble();
            ven.ShowDialog();
        }
       

        private void arbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArbol ven = new frmArbol();  
            ven.ShowDialog();   
        }

        private void grafoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrafos ven = new frmGrafos();
            ven.ShowDialog();
        }

        private void consultaDeUnaTablaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdConsultaTablas ven = new frmBdConsultaTablas();    
            ven.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmBdConsultaSql ven = new frmBdConsultaSql();
            ven.ShowDialog();
        }

        private void operacionesEnBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdOperaciones ven = new frmBdOperaciones();
            ven.ShowDialog();
        }

        private void consultasVariasConOperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBdRepaso ven = new frmBdRepaso();
            ven.ShowDialog();
        }
    }
}

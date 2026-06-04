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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos sql = new clsBaseDatos();

        private void btnProSimple_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO" +
                "FROM LIBRO" +
                "ORDER BY 1 DESC";
            sql.Listar(dgvOperaciones, varSql);
        }

        private void btnProMultiAtributo_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT TITULO, AÑO" +
                "FROM LIBRO" +
                "ORDER BY TITULO ASC";
            sql.Listar(dgvOperaciones, varSql);
        }

        private void btnJuntar_Click(object sender, EventArgs e)
        {
            String varSql = "SELECT Libro.Titulo, Autor.Nombre" +
                "FROM Libro INNER JOIN Autor" +
                "ON Libro.IdAutor = Autor.IdAutor";
            sql.Listar(dgvOperaciones, varSql);
        }
    }
}

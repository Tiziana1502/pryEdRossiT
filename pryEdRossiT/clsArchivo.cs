using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria que permite procesar archivos
using System.IO;
using System.Windows.Forms;

namespace pryEdRossiT
{
    internal class clsArchivo
    {
        //Creo un campo
        public string NombreArc = ""; //guarda el nombre del archivo (propiedad)


        public void Grabar()
        {
            //Abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NombreArc);
            AD.WriteLine("Hola!!!");
            AD.Close();
        }

        public void Grabar(string Dato)
        {
            //Abrir archivo para escritura 
            StreamWriter AD = new StreamWriter(NombreArc, true);
            AD.WriteLine(Dato);
            AD.Close();
        }

        public void LimpiarTodo()
        {
            StreamWriter AD = new StreamWriter(NombreArc, false); //Abre y pisa el que existe            
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        { 
            lstDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NombreArc);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

         //Instancio una sobrecarga pero con combo box y datagridview

        public void Recorrer(ComboBox cmbDatos)
        {
            cmbDatos.Items.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NombreArc);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cmbDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView dgvDatos)
        {
            dgvDatos.Rows.Clear();
            string DatoLeido = "";
            StreamReader AD = new StreamReader(NombreArc);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                dgvDatos.Rows.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

    }

}

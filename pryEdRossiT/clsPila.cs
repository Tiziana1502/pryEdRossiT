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
    internal class clsPila
    {
        //Estructura de datos dinámica y lineal. el ultim0o dato en llegar es el primero que se va
        //Campos de la clase
        private clsNodo pri;

        //Propiedades 
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;               
            }
            else
            {
                Nuevo.Siguiente = Primero;
                Primero = Nuevo;
            }
        }
        public void Eliminar()
        {
            if (Primero != null)
            {
                Primero = Primero.Siguiente;
            }            
        }

        public void Recorrer(DataGridView Grilla)
        {
            clsNodo Aux = Primero;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ListBox Lista)
        {
            clsNodo Aux = Primero;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Nombre);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Tramite);
                Aux = Aux.Siguiente;
            }

        }
        public void Recorrer(string NombreArchivo)
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Lista de espera\n");
            AD.WriteLine("Código; Nombre; Trámite");
            while (Aux != null)
            {
                AD.Write(Aux.Codigo);
                AD.Write(";");
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite);
                Aux = Aux.Siguiente;
            }
            AD.Close();
        }
    }
}

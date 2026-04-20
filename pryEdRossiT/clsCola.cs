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
    //Estructura de datos dinámica y lineal, el primer dato se guarda al final y se elimina el primero
    //Solo se pueden realizar 3 métodos, agregar, eliminar y recorrer
    internal class clsCola
    {
        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades de la clase
        public clsNodo Primero
        { 
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }

        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Ultimo = Nuevo;
            }
        }

        public void Eliminar()
        {
            if (Primero == Ultimo)
            {
                Primero = null;
                Ultimo = null;
            }
            else
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
    }
}

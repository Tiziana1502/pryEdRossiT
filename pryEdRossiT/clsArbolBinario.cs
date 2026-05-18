using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdRossiT
{
    //Estructura de datos jerarquica, cada nodo tiene 2 hijos, el puntero primero se llama raiz, lado izquierdo son menores a la raiz y el lado derecho son mayores
    //Equilibrar, Busqueda
    internal class clsArbolBinario
    {
        //Campo inicial del arbol se llama raiz
        private clsNodo primerNodo;
        //Propiedad
        public clsNodo Raiz
        {
            get { return primerNodo; }
            set { primerNodo = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Raiz == null)
            {
                Raiz = Nuevo;
            }
            else
            {
                clsNodo ant = Raiz;
                clsNodo aux = Raiz;
                while (aux != null)
                {
                    ant = aux;
                    if (Nuevo.Codigo < aux.Codigo) aux = aux.Izquierdo; //Cuando el codigo sea menor a la raiz(que esta en aux) va a ir del lado izquierdo
                    else aux = aux.Derecho; //si el codigo es mayor a la raiz, pasa al lado derecho del arbol
                }
                if (Nuevo.Codigo < ant.Codigo) ant.Izquierdo = Nuevo;
                else ant.Derecho = Nuevo;
            }
        }
        public void Recorrer(DataGridView Grilla)
        { 
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView dgv, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(dgv, R.Izquierdo);
            dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null) InOrdenAsc(dgv, R.Derecho);
        }
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox lst, clsNodo R)
        {
            if (R.Izquierdo != null) InOrdenAsc(lst, R.Izquierdo);
            lst.Items.Add(R.Codigo);
            if (R.Derecho != null) InOrdenAsc(lst, R.Derecho);
        }
    }   
}

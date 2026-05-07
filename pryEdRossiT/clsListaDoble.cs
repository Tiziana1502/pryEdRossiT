using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdRossiT
{
    internal class clsListaDoble
    {
        //Formada por nodos, contienen 3 partes, los datos y el puntero del dato anterior y ultimo, se puede recorrer en ambas direcciones
        //Campos de la clase
        private clsNodo pri;
        private clsNodo ult;

        //Propiedades
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
                if (Nuevo.Codigo < Primero.Codigo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else 
                {
                    if (Nuevo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.Codigo < Nuevo.Codigo)
                        { 
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;

                    }
                }
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Codigo == Primero.Codigo && Primero == Ultimo) //Si existe un solo dato en la lista
            {
                Primero = null;
                Ultimo = null;               
            }
            else
            {
                if (Primero.Codigo == Codigo) //Si es el primer dato
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null; //Al ser el primer dato que existe le doy valor nulo para que pase a ser el primero
                }
                else 
                {
                    if (Ultimo.Codigo == Codigo) //Si es el ultimo dato
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else //Cuando se encuentra en el medio de otro dato
                    {
                        clsNodo aux = Primero;
                        clsNodo ant = Primero;
                        while (aux.Codigo < Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        aux.Siguiente = aux;
                        ant.Siguiente = aux;
                        aux.Anterior = ant;
                    }
                }
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
        public void RecorrerDesc(DataGridView Grilla)
        {
            clsNodo Aux = Ultimo;
            Grilla.Rows.Clear();
            while (Aux != null)
            {
                Grilla.Rows.Add(Aux.Codigo, Aux.Nombre, Aux.Tramite);
                Aux = Aux.Anterior;
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
        public void RecorrerDesc(ListBox Lista)
        {
            clsNodo Aux = Ultimo;
            Lista.Items.Clear();
            while (Aux != null)
            {
                Lista.Items.Add(Aux.Nombre);
                Aux = Aux.Anterior;
            }

        }

        public void Recorrer(ComboBox Combo)
        {
            clsNodo Aux = Primero;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Siguiente;
            }

        }
        public void RecorrerDesc(ComboBox Combo)
        {
            clsNodo Aux = Ultimo;
            Combo.Items.Clear();
            while (Aux != null)
            {
                Combo.Items.Add(Aux.Codigo);
                Aux = Aux.Anterior;
            }

        }
        public void Recorrer(string NombreArchivo)
        {
            clsNodo Aux = Primero;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
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
        public void RecorrerDesc(string NombreArchivo)
        {
            clsNodo Aux = Ultimo;
            StreamWriter AD = new StreamWriter(NombreArchivo, false, Encoding.UTF8);
            AD.WriteLine("Código; Nombre; Trámite");
            while (Aux != null)
            {
                AD.Write(Aux.Codigo);
                AD.Write(";");
                AD.Write(Aux.Nombre);
                AD.Write(";");
                AD.WriteLine(Aux.Tramite);
                Aux = Aux.Anterior;
            }
            AD.Close();
        }
    }
}

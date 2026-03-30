using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Libreria que permite procesar archivos
using System.IO;

namespace pryEdRossiT
{
    internal class clsArchivo
    {
        //Creo un campo
        public string NombreArc = "Colores.txt"; //guarda el nombre del archivo (propiedad)


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
    }

}

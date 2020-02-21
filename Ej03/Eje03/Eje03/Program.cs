using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eje03
{
    class Program
    {
        static void Main(string[] args)
        {
            //para las listas se escribe asi-->
            List<int> numbers = new List<int>();
            List<float> asd = new List<float>();
            List<char> asddas = new List<char>();
            //Añade al final de la cadena
            asd.Add(1);
            asd.Add(2);
            asd.Add(30);
            //Elemina el primer contenedor que contenga ese numero
            asd.Remove(1);
            //Elemina el contenedor con el indice que especifiques
            asd.RemoveAt(1);
        }
    }
}

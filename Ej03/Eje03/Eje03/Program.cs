using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Eje03
{
    class Program
    {
        static void Main(string[] args)
        {
            ////para las listas se escribe asi-->
            //List<int> numbers = new List<int>();
            //List<float> asd = new List<float>();
            //List<char> asddas = new List<char>();
            ////Añade al final de la cadena
            //asd.Add(1);
            //asd.Add(2);
            //asd.Add(30);
            ////Elemina el primer contenedor que contenga ese numero
            //asd.Remove(1);
            ////Elemina el contenedor con el indice que especifiques
            //asd.RemoveAt(1);
            List<float> numeros = new List<float>();
            bool stop = false;
            float Nuevo;
            while (stop==false)
            {
                Console.WriteLine("Escribe un numero entero, escribe -1 para ejecutar");
                Nuevo = float.Parse(Console.ReadLine());
                if (Nuevo >0)
                {
                    numeros.Add(Nuevo);
                }
                else if (Nuevo==-1)
                {
                    stop = true;
                }
            }
            foreach (float Indv in numeros)
            {
                if (Indv%2==0)
                {
                    Console.WriteLine("El numero " + Indv + " es par");
                }
                else
                {
                    Console.WriteLine("El numero " + Indv + " es inpar");
                }
            }
            Thread.Sleep(5000);
        }
    }
}

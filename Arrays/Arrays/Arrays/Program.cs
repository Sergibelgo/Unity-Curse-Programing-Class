using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para declarar arrays primero el tipo de array luego [] y luego el nombre
            //int[] numeros;
            ////Para inicializarla, primero el comando new, luego el tipo de contenedor y luego el numero de cajas entre []
            //numeros = new int[3];
            // tipo[] nombre = new tipo[n]
            Console.WriteLine("Dame un numero");
            int numero = int.Parse(Console.ReadLine());
            int[] numeros = new int[numero];
            int sumatorio = 0;
            for (int i = 0; i < numero; i++)
            { 
                Console.WriteLine("Dame ahora otro");
                int numerosumar = int.Parse(Console.ReadLine());
                numeros[i] = numerosumar;
            }
            for (int e = 0; e < numeros.Length; e++)
            {
                sumatorio = sumatorio + numeros[e];
            }
            Console.WriteLine("La suma total es de " + sumatorio);
            Thread.Sleep(2000);
        }
    }
}

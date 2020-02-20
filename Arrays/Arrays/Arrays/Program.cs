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
            ////Console.WriteLine("Dame un numero");
            ////int numero = int.Parse(Console.ReadLine());
            ////int[] numeros = new int[numero];
            ////int sumatorio = 0;
            ////for (int i = 0; i < numero; i++)
            ////{ 
            ////    Console.WriteLine("Dame ahora otro");
            ////    int numerosumar = int.Parse(Console.ReadLine());
            ////    numeros[i] = numerosumar;
            ////}
            ////for (int e = 0; e < numeros.Length; e++)
            ////{
            ////    sumatorio = sumatorio + numeros[e];
            ////}
            ////Console.WriteLine("La suma total es de " + sumatorio);
            ////Thread.Sleep(2000);
            ///
            //DEMOSTRACION DE QUE SI COPIAS DIRECTAMENTE 1 ARRAY Y OTRA HACEN REFERENCIA AL MISMO ESPACIO EN MEMORIA Y POR ENDE SE VUELVEN EXACTAMENTE LA MISMA VARIABLE
            //Es decir, modifiques una u otra modificas ambas a la vez y de forma igual--->
            //int[] numeros = { 1, 2, 1, 3 };
            //int[] numeros02 = new int[4];
            //numeros = numeros02;
            //numeros[0] = 0;
            //Console.WriteLine(numeros[0] + " y " + numeros02[0]);
            //Thread.Sleep(6000);
            //Ejercicio opcional: El usuario introduce un numero x de numeros hay que ordenarlos de mayor a menor

        }
    }
}

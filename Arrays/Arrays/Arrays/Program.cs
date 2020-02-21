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
            //int x = 3;
            //int y = 4;
            //Console.WriteLine("Praa " + x + " " + y);
            //int comodin = 0;
            //Console.WriteLine();
            //comodin = y;
            //y = x;
            //x = comodin;
            //Console.WriteLine("Pum " + x + " " + y);
            //Thread.Sleep(5000);
            //Piramide de asteriscos
            ////Console.WriteLine("Introduce cuantas filas quieres");
            ////int aux = 1;
            ////int numero = int.Parse(Console.ReadLine());
            ////for (int i = 0; i < numero; i++)
            ////{
            ////    for (int j = 0; j < aux; j++)
            ////    {
            ////        Console.Write("*");
            ////    }
            ////    Console.WriteLine();
            ////    aux++;
            ////}
            ////Thread.Sleep(5000);
            //_-_-_
            //_xxx-
            //xxxxx
            //int numero = int.Parse(Console.ReadLine());
            //int aux = 0;
            //int aux02 = numero / 2;
            //char[] letra = new char[numero];
            //for (int i = 0; i < numero; i++)
            //{
            //    for (int j = 0; j < aux; j++)
            //    {
            //        if (numero%2==0)
            //        {


            //        }
            //    }
            //    Console.WriteLine();
            //}
            int[] numeros = { 1, 2, 3, 0, 1, 4 };
            Console.Write(numeros);
            Thread.Sleep(5000);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio02
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Dame un numero");
        //    int numero = int.Parse(Console.ReadLine());
        //    Console.WriteLine();
        //    int numbfin = 0;
        //    for (int i = 0; i <= numero; i++)
        //    {
        //        numbfin = numbfin + i;
        //    }
        //    Console.WriteLine("El resultado de la suma de todos los numeros consecutivos es: " + numbfin);
        //    Thread.Sleep(4000);

        //}
        //Ejemplo para crear otras funciones distintas a la Main
        static void Main()
        {
            Console.WriteLine("Dame millas y las convertire en Km");
            float Muser = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(MillastoKm(Muser) + "Km");
            Thread.Sleep(2000);
        }
        //Para crear otras funciones que no sean la main-->
        static float MillastoKm (float Km)
        {
            float millas = Km * 1.60934f;
            return millas;
        }
    }
}

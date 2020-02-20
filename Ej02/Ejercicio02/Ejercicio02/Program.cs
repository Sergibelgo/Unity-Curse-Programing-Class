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
        static void Main(string[] args)
        {
            Console.WriteLine("Dame un numero");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            int o = 0;
            do
            {
                Console.WriteLine(o);
                o++;
            } while (o<=numero);
            Thread.Sleep(2000);

        }
    }
}

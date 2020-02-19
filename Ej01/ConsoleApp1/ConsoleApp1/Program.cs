using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ejercio 1
            ////numero 1
            //float x;
            ////numero 2
            //float y;
            ////Definicion de numero 1
            //Console.WriteLine("Escribe un numero por favor");
            //x = float.Parse(Console.ReadLine());
            ////Definicion de numero 2
            //Console.WriteLine("Escribe el mismo numero por favor");
            //y = float.Parse(Console.ReadLine());
            ////Comprobamos si son el mismo numero
            //if (x == y) 
            //{
            //    Console.WriteLine("Los numeros: " + x + " y " + y + " son iguales");
            //    Thread.Sleep(2000);
            //}
            ////Comprobamos si el numero a es mayor que b
            //else if (x>y)
            //{
            //    Console.WriteLine("El numero "+ x + " es mayor que " + y);
            //    Thread.Sleep(2000);
            //}
            //// Como solo queda una opcion no hace falta especificar que sea menor que
            //else
            //{
            //    Console.WriteLine("El numero " + y + " es mayor que " + x);
            //    Thread.Sleep(2000);
            //}
            //Ejercicio 2
            ////Definimos numero a pedir
            //float x;
            //float y;
            ////Pedimos al usuario que lo introduzca
            //Console.WriteLine("Escribe un numero por favor");
            //x = float.Parse(Console.ReadLine());
            //Console.WriteLine("Escribe otro numero");
            //y = float.Parse(Console.ReadLine());
            ////Comprobamos si es par o inpar
            //if ((x % y)==0)
            //{
            //    Console.WriteLine("Es multiplo");
            //    Thread.Sleep(2000);
            //}
            //else
            //{
            //    Console.WriteLine("No es multiplo");
            //    Thread.Sleep(2000);
            //}
            //Ejerciocio 3
            //float x;
            //Console.WriteLine("Escribe un numero por favor");
            //x = float.Parse(Console.ReadLine());
            //if (x<0)
            //{
            //    Console.WriteLine("Es negativo");
            //    Thread.Sleep(2000);
            //}
            //else if (x>0)
            //{
            //    Console.WriteLine("Es positivo");
            //    Thread.Sleep(2000);
            //}
            //else
            //{
            //    Console.WriteLine("Es cero");
            //    Thread.Sleep(2000);
            //}
            //ejercicio 4
            //int x;
            //Console.WriteLine("Hola buenas ¿Que deseas?");
            //Console.WriteLine("1. Refrán");
            //Console.WriteLine("2. Chiste");
            //Console.WriteLine("3. Insulto");
            //x = int.Parse(Console.ReadLine());
            //switch (x)
            //{
            //    default:
            //        Console.WriteLine("Te has equivocado, inutil");
            //        Thread.Sleep(2000);
            //        break;
            //    case 1:
            //        Console.WriteLine("Mas sabe el diablo por viejo que por diablo");
            //        Thread.Sleep(2000);
            //        break;
            //    case 2:
            //        Console.WriteLine("Van dos y se cae el de la derecha, y dice el del medio -Por fin no me caigo yo");
            //        Thread.Sleep(2000);
            //        break;
            //    case 3:
            //        Console.WriteLine("MIRA, UN MONO DE TRES CABEZAS");
            //        Thread.Sleep(2000);
            //        break;
            //}
            //Ejercicio 5
            //float x;
            //float y;
            //float z;
            //Console.WriteLine("Dime tu nota primera");
            //x = float.Parse(Console.ReadLine());
            //Console.WriteLine("Dime tu nota segunda");
            //y = float.Parse(Console.ReadLine());
            //Console.WriteLine("Dime tu nota tercera");
            //z = float.Parse(Console.ReadLine());
            //Console.WriteLine("La media es " + ((x + y + z) / 3f));
            //Thread.Sleep(2000);
            //Ejercicio 6
            //float x;
            //Console.WriteLine("Dime tu estatura en cm");
            //x = float.Parse(Console.ReadLine());
            //if (x >= 40)
            //{
            //    if (x >= 40 && x <= 140)
            //    {
            //        Console.WriteLine("JAJA, BAJITO");
            //        Thread.Sleep(2000);
            //    }
            //    else if (x > 140 && x < 200)
            //    {
            //        Console.WriteLine("Not bad");
            //        Thread.Sleep(2000);
            //    }
            //    else
            //    {
            //        Console.WriteLine("DAAMMM BOY");
            //        Thread.Sleep(2000);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Ja ja, muy gracioso");
            //    Thread.Sleep(2000);
            //}
            // Ejerciocio 7
            Console.WriteLine("Dame un numero para multiplicar");
            int multiplicador = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuantas veces lo multiplico?");
            int repeticiones = int.Parse(Console.ReadLine());
            int contador = 0;
            while (contador <= repeticiones)
            {
                Console.WriteLine(multiplicador + " x " + contador + " es: " + (multiplicador*contador));
                contador++;

            }
            Thread.Sleep(4000);
            
        }
    }
}

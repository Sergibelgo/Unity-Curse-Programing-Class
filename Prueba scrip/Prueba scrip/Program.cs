using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Prueba_scrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba 01

            ////Los comentarios son con doble barra
            //// int numeros enteros
            //int x;
            //int g;
            //// float para numeros decimales
            //float y = 1.5f;
            //// double para numeros decimales muy grandes
            //double z = 1.00000000000000000000000000000000000000000000005d;
            //// Char para letras, la comillasimple esta debajo del signo de cerrar interrogacion
            //char letra = 'A';
            //// string para frases
            //string Frase = "Hola buenas tardes, ¿Me puedes dar un numero entero ahora?";
            //// bool para verdadero falso
            //bool Verdadero = true;
            //string Saludo;
            //// Console.WriteLine es para escribir en la consola
            //Console.WriteLine("¿Me dices hola?");
            //// Console.ReadLine le pide al usuario que escriba
            //// Pedimos al usuario que salude al programa, por que la caballeria no esta muerta
            //Saludo = Console.ReadLine();
            //// Comprobamos si nos ha saludado o no
            //if ((Saludo == "Hola") || (Saludo=="hola"))
            //{
            //    // Como nos ha saludado le pedimos un numero entero para sumar
            //    Console.WriteLine(Frase);
            //    // Esto lo de int y todo eso es para comprobar que el numero que te da el usuario es entero
            //    // Comprobamos si el numero es entero o no
            //    if (Int32.TryParse(Console.ReadLine(), out x))
            //    {
            //        // Como el numero es entero le pedimos el otro numero
            //        Console.WriteLine("Ahora dame otro numero entero por favor");
            //        // Comprobamos si el otro numero es entero o no
            //        if (Int32.TryParse(Console.ReadLine(), out g))
            //        {
            //            // Sumamos los dos numeros enteros y se lo mostramos al usuario
            //            Console.WriteLine("La suma es " + (x + g));
            //            Console.WriteLine("La resta es " + (x - g));
            //            Console.WriteLine("La multiplicacion es " + (x * g));
            //            Console.WriteLine("La division es " + (x / g));
            //            Console.WriteLine("Hasta luego");
            //            Thread.Sleep(2000);
            //        } 
            //        else
            //        {
            //            // El numero no ha sido entero
            //            Console.WriteLine("Eso no es un numero entero");
            //            Thread.Sleep(2000);
            //        }
            //    }
            //    else
            //    // El numero no ha sido entero
            //    {
            //        Console.WriteLine("Eso no es un numero entero");
            //        Thread.Sleep(2000);
            //    }
            //}
            //else
            //{
            //    // El usuario no ha saludado al programa
            //    Console.WriteLine("Eres un maleducado");
            //    Thread.Sleep(2000);
            //}
            ////Ejerciocio 02
            //Console.WriteLine("¿Que edad tienes?");
            //int edad = int.Parse(Console.ReadLine());
            //if (edad < 18)
            //{
            //    Console.WriteLine("Eres menor de edad");
            //    Thread.Sleep(2000);
            //} else if(edad >= 65)
            //{
            //    Console.WriteLine("Eres un jubilado");
            //    Thread.Sleep(2000);
            //}
            //else
            //{
            //    Console.WriteLine("Eres mayor de edad");
            //    Thread.Sleep(2000);
            //}
            ////Ejercicio 03
            //Console.WriteLine("¿Que nota has sacado?");
            //float nota = float.Parse(Console.ReadLine());
            //if (nota >= 0 && nota<=10)
            //{
            //    if (nota < 5)
            //    {
            //        Console.WriteLine("Suspenso");
            //        Thread.Sleep(2000);
            //    }
            //    else if (nota>= 5 && nota<6)
            //    {
            //        Console.WriteLine("Aprovado");
            //        Thread.Sleep(2000);
            //    }
            //    else if (nota>= 6 && nota<7)
            //    {
            //        Console.WriteLine("Bien");
            //        Thread.Sleep(2000);
            //    }
            //    else if (nota>6 && nota < 9)
            //    {
            //        Console.WriteLine("Notable");
            //        Thread.Sleep(2000);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sobresaliente");
            //        Thread.Sleep(2000);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No es una nota valida");
            //    Thread.Sleep(2000);
            //}4
            //Ejercicio 04
            
            int nota =0;
            while (nota != -1) {
                Console.WriteLine("¿Que nota has sacado?");
                nota = int.Parse(Console.ReadLine());
                switch (nota)
            {
                    case -1:
                        break;
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("suspenso");
                        break;
                case 5:
                    Console.WriteLine("Aprovado");
                    
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    
                    break;
                case 7:
                case 8:
                    Console.WriteLine("Notable");
                    
                    break;
                case 9:
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("No es una nota valida");
                    break;
            }
            }
            Console.WriteLine("Saliendo");
            Thread.Sleep(2000);
        }
    }
}

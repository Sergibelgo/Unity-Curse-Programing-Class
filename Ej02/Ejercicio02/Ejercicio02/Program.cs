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
        ////Ejemplo para crear otras funciones distintas a la Main
        //static void Main()
        //{
        //    Console.WriteLine("Dame millas y las convertire en Km");
        //    float Muser = float.Parse(Console.ReadLine());
        //    Console.WriteLine();
        //    Console.WriteLine(MillastoKm(Muser) + "Km");
        //    Thread.Sleep(2000);
        //}
        ////Para crear otras funciones que no sean la main-->
        //static float MillastoKm (float Km)
        //{
        //    float millas = Km * 1.60934f;
        //    return millas;
        //}
        //static void Main (string[] args)
        //{
        //    Console.WriteLine("Dame un numero");
        //    int numero = int.Parse(Console.ReadLine());
        //    Console.WriteLine();
        //    for (; numero>=0; numero--)
        //    {
        //        Console.WriteLine(numero);
        //    }
        //    Thread.Sleep(2000);
        //}
        static void Main (string[] args)
        {
            // vida inicial del jugador
            int vida = 10;
            // variable para dar opciones al jugador
            int accion;
            // Comando para crear un sistema random en una variable
            Random r = new Random();
            // Designar a la variable random un random entre 0 y 10
            int random = r.Next(0,10);
            // vida de los 10 enemigos que puede haber en pantalla
            int[] enemyslive = new int[] {10,0,0,0,0,0,0,0,0,0};
            // Contador para saber cuantos enemigos hay
            int enemycounter = 0;
            int counter = 0;
            // Comprobante para saber cuando huye el usuario
            bool salida = false;
            // Puntos del jugador que gana por cada enemigo muerto
            int puntos = 0;
            // Comprobar que el usuario no haya huido o muerto
            for (; vida > 0 && salida==false;EnemigoSpawn(random))
            {
                Opciones();
                switch (accion)
                {
                    //caso ataque
                    case 1:
                        Atack();
                        EnemyAtack(0);
                        random = r.Next(0, 10);
                        break;
                    case 2:
                        Heal(3);
                        EnemyAtack(2);
                        break;
                    case 3:
                        salida = true;
                        break;
                    default:
                        Console.WriteLine("Tu mente se bloquea");
                        //Reseteamos el counter
                        counter = 0;
                        //Mientras el counter sea menos a la cantidad de enemigos estos atacan
                        EnemyAtack(0);
                        random = r.Next(0, 10);
                        break;
                }

            }
            if (vida<=0)
            {
                Console.WriteLine("Has muerto");
            }
            else
            {
                Console.WriteLine("Consigues huir, tu puntuacion es de " + puntos);
            }
            Thread.Sleep(6000);
            //Funcion para que el jugador pueda eleguir opciones
            void Opciones()
            {
                Console.WriteLine();
                //Opciones del jugador y que decide
                Console.WriteLine("Los enemigos te rodean, que accion tomaras:");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Bloquear");
                Console.WriteLine("3. Huir");
                Console.WriteLine("HP: " + vida);
                //Comprobamos si el jugador a introducido un numero o no
                Int32.TryParse(Console.ReadLine(), out accion);
            }
            //Funcion para decidir si aparece o no un enemigo
            void EnemigoSpawn(int RandomSpaw)
            {
                random = r.Next(0, 10);
                if (RandomSpaw > 4 && enemycounter<10)
                {
                    enemycounter++;
                    enemyslive[enemycounter] = 10;
                    Console.WriteLine("Ha aparecido un nuevo enemigo");
                }
            }
            // Funcion de ataque
            void Atack(){
                //Contador de veces que hara la accion
                 counter = 0;
                // Aleatorizar el numero
                random = r.Next(0, 10);
                // Mientras el contador no sea igual al numero de enemigos sigue atacando
                while (counter <= enemycounter)
                {
                    // Si el numero aleatorio es mayor a 3 el ataque hacierta
                    if (random > 3)
                    {
                        // Volvemos a ramdomizar el numero
                        random = r.Next(0, 10);
                        // Le quitamos esa cantidad de vida al enemigo
                        enemyslive[counter] = enemyslive[counter] - random;
                        //Comprobamos si el enemigo a muerto
                        if (enemyslive[counter] <= 0)
                        {
                            //Informamos al usuario de que el enemigo a muerto
                            Console.WriteLine("El enemigo numero " + counter + " ha muerto. El enemigo numero " + enemycounter + " toma su posicion.");
                            //Le añadimos un punto
                            puntos++;
                            //Sustituimos al enemigo muerto por el ultimo enemigo que se halla presentado
                            enemyslive[counter] = enemyslive[enemycounter];
                            //Quitamos 1 al contador de enemigos
                            enemycounter--;
                        }
                        else
                        {
                            //Informamos al usuario que ha dado el golpe
                            Console.WriteLine("Golpeas al enemigo numero " + counter + " por " + random);
                        }
                    }
                    else
                    {
                        //Informamos al usuario que ha fallado el golpe
                        Console.WriteLine("Fallas al enemigo numero " + counter);
                    }
                    counter++;
                }
            }
            //Funcion de ataque enemigo
            void EnemyAtack(int Defensiva)
            {
                // Aleatorizar el numero
                counter = 0;
                random = r.Next(0, 10);
                while (counter <= enemycounter)
                {
                    //Randomizamos el numero
                    random = r.Next(0, 10);
                    //Le restamos para bajar la probabilidad de daño
                    random -= Defensiva;
                    //Comprobamos si hacierta
                    if (random > 4)
                    {

                        random = r.Next(0, 6);
                        vida = vida - random;
                        Console.WriteLine("El enemigo numero " + counter + " te hiere por " + random);
                    }
                    else
                    {
                        Console.WriteLine("El enemigo numero " + counter + " ha sido bloqueado");
                    }
                    counter++;
                }
            }
            //Funcion de bloqueo
            void Heal(int curacion)
            {
                //Contador de veces que hara la accion
                counter = 0;
                // Curamos al jugador
                if (vida < 15)
                {
                    vida += curacion;
                    //Limitamos al vida a 15
                    if (vida >= 13)
                    {
                        vida = 15;
                    }
                }
                //Limitamos la vida a 15
            }
        }
        
    }
}

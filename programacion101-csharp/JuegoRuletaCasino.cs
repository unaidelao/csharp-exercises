/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que juegue automáticamente a la ruleta. Iremos al casino con
 * un saldo de 1000 euros y nos retiraremos si hemos ganado 1000 más (Es decir,
 * nos vamos con 2000) o si perdemos todo.
 * Nos servirá para saber que la banca siempre gana.
 *
 * Autor: Unai de la O.
 */

 using System;

 class JuegoRuletaCasino
 {
   public static void Main(string[] args)
   {
     int saldo = 1000;
     Random numAleatorio = new Random();

     Console.ForegroundColor = ConsoleColor.Yellow;
     Console.WriteLine("\nRULETA CASINO");
     Console.WriteLine("-------------");
     Console.ResetColor();
     Console.WriteLine("Instrucciones: jugarás hasta quedarte a 0 o si " +
                       "alcanzas los 2000 euros.\n");

     while ((saldo > 0) && (saldo < 2000))
     {
       Console.WriteLine("Saldo actual: {0}", saldo);
       Console.Write("Indique dinero a apostar: ");
       int apuesta = int.Parse(Console.ReadLine());
       if (apuesta > saldo)
       {
         Console.WriteLine("No puedes apostar tanto!!\n");
         continue;
       }
       Console.Write("Indique casilla a apostar: ");
       // Las casillas de la ruleta son 36.
       int casillaUsuario = int.Parse(Console.ReadLine());
       // Se genera la casilla ganadora
       int casillaPremiada = numAleatorio.Next(0, 37);

       if (casillaUsuario == casillaPremiada)
       {
         // Si aciertas, te llevas 35 veces tu apuesta.
         saldo += apuesta * 35;
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("¡Acertaste!\n");
         Console.ResetColor();
       }
       else
       {
         Console.ForegroundColor = ConsoleColor.Red;
         Console.WriteLine("¡Fallaste!. Casilla premiada: {0}.\n", casillaPremiada);
         Console.ResetColor();
         saldo -= apuesta;
       }
     }

     Console.WriteLine("Fin de la partida. Tu saldo es {0}.\n", saldo);
     Console.WriteLine("Pulse una tecla para finalizar el programa...");
     Console.ReadKey();
   }
 }

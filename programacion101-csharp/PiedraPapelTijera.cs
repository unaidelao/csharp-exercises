/*
 * Programación 101 - C# Básico
 *
 * Hay un juego de dos personas que se llama "PIEDRA; PAPEL O TIJERA", donde
 * cada uno de los usuarios tiene que introducir Piedra, Papel o Tijera, y la
 * máquina dar el resultado: "Piedra gana a tijera: Gana el jugador 1".
 *
 * Autor: Unai de la O.
 */

 using System;

 class PiedraPapelTijera
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("\nPIEDRA - PAPEL - TIJERA\n");
     Console.WriteLine("Instrucciones:");
     Console.WriteLine("\tPulsa 1 para \"piedra\".");
     Console.WriteLine("\tPulsa 2 para \"papel\".");
     Console.WriteLine("\tPulsa 3 para \"tijera\".\n");

     Console.Write("Jugador 1, introduce tu opción: ");
     int opcionJ1 = int.Parse(Console.ReadLine());

     Console.Write("Jugador 2, introduce tu opción: ");
     int opcionJ2 = int.Parse(Console.ReadLine());

     /*
      * Piedra gana a Tijera; Piedra pierde contra Papel.
      * Papel gana a Piedra; Papel pierde contra Tijera.
      * Tijera gana a Papel; Tijera pierde contra Piedra.
      */

     if (opcionJ1 == 1)
     {
       if (opcionJ2 == 3)
       {
         Console.WriteLine("Piedra gana a Tijera: Gana Jugador 1.");
       }
       else if (opcionJ2 == 2)
       {
         Console.WriteLine("Papel gana a Piedra: Gana Jugador 2.");
       }
       else
       {
         Console.WriteLine("Empate!!");
       }
     }

     else if (opcionJ1 == 2)
     {
       if (opcionJ2 == 1)
       {
         Console.WriteLine("Papel gana a Piedra: Gana Jugador 1.");
       }
       else if (opcionJ2 == 3)
       {
         Console.WriteLine("Tijera gana a Papel: Gana Jugador 2.");
       }
       else
       {
         Console.WriteLine("Empate!!");
       }
     }

     else if (opcionJ1 == 3)
     {
       if (opcionJ2 == 2)
       {
         Console.WriteLine("Tijera gana a Papel: Gana Jugador 1.");
       }
       else if (opcionJ2 == 1)
       {
         Console.WriteLine("Piedra gana a Tijera: Gana Jugador 2.");
       }
       else
       {
         Console.WriteLine("Empate!!");
       }
     }
     // Fin del programa.
     Console.Write("\nFin del Juego. Pulsa una tecla para salir...");
     Console.ReadKey();
   }
 }

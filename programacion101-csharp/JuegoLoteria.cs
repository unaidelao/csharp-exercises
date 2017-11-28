/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que juegue automáticamente a la lotería. Suponiendo que
 * juegas una vez por semana, calcula cuantos años comprando el mismo número
 * necesitarás para que te toque.
 *
 * El resultado siempre será diferente, pero al menos nos quedará claro que es
 * casi imposible que nos hagamos millonarios jugando a la lotería.
 *
 * En el caso de la lotería española, se juegan cinco cifras, por ejemplo,
 * el número premiado puede ser 91374.
 *
 * Autor: Unai de la O.
 */

 using System;

 class JuegoLoteria
 {
   public static void Main(string[] args)
   {
     Random numAleatorio = new Random();
     // Por ejemplo, este es el décimo que se jugará todas las semanas.
     int decimoDelUsuario = 34502;
     bool pierde = true;
     int semanasJugadas = 0;

     while(pierde)
     {
       semanasJugadas++;
       int numeroPremiado = numAleatorio.Next(0, 100000);
       if (numeroPremiado == decimoDelUsuario)
       {
         pierde = false;
       }
     }
     int anyosJugados = semanasJugadas / 52;

     Console.WriteLine("Has jugado {0} veces hasta que te ha tocado la " +
                       "lotería, es decir, {1} años."
                       , semanasJugadas
                       , anyosJugados);

     // Invitación al usuario para finalizar el programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

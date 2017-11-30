/*
 * Programación 101 - C# Básico
 *
 * Extiende tu juego de la ruleta de casino para que haga 1000 veces lo mismo.
 * Guarda en dos variables cuantas veces te vas con 2000 euros y cuantas veces
 * te arruinas.
 *
 * Autor: Unai de la O.
 */

 using System;

 class JuegoRuletaCasinoAutomatico
 {
   public static void Main(string[] args)
   {
     int visitasAlCasino = 1000;
     int saldo = 1000;
     int totalGanadas = 0;
     int totalArruinadas = 0;
     Random numAleatorio = new Random();

     Console.ForegroundColor = ConsoleColor.Yellow;
     Console.WriteLine("\nRULETA CASINO");
     Console.WriteLine("versión Automática: 1000 visitas al casino.");
     Console.WriteLine("-------------------------------------------");
     Console.ResetColor();
     Console.WriteLine("Instrucciones: jugarás hasta quedarte a 0 o si " +
                       "alcanzas los 2000 euros.\n");

     for (int i = 0; i < visitasAlCasino; i++)
     {
       while ((saldo > 0) && (saldo < 2000))
       {
         Console.WriteLine("Saldo actual: {0}", saldo);
         Console.Write("Indique dinero a apostar: ");
         int apuesta = numAleatorio.Next(1, saldo + 1);
         Console.WriteLine(apuesta);
         Console.Write("Indique casilla a apostar: ");
         // Las casillas de la ruleta son 36.
         int casillaUsuario = numAleatorio.Next(0, 37);
         Console.WriteLine(casillaUsuario);
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
       if (saldo >= 2000)
       {
         totalGanadas++;
       }
       else if (saldo <= 0)
       {
         totalArruinadas++;
       }
       // Se reestablece de nuevo el saldo a 1000 para una nueva visita al Casino.
       saldo = 1000;
     }
     Console.WriteLine("Visitas al casino ganadas: {0}", totalGanadas);
     Console.WriteLine("Visitas al casino arruinadas: {0}", totalArruinadas);

     // Invitación al usuario para finalizar el programa.
     Console.WriteLine("Pulse una tecla para finalizar el programa...");
     Console.ReadKey();
   }
 }

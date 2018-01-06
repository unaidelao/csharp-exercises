/*
 * Programación 101 - C# Básico
 *
 * Haz un juego donde el ordenador genera un número aleatorio del 0 al 100 y el
 * usuario tiene que intentar adivinarlo. Cada vez que falle, se le dirá si el
 * número es mayor o menor que el que se ha escrito, para pasar a otra
 * oportunidad. Cuándo el usuario lo adivine, el programa debe decir cuántos
 * intentos ha necesitado. No dejes que el programa falle por introducir otras
 * cosas en vez de números.
 *
 * Autor: Unai de la O.
 */
 using System;

 class JuegoAdivinarNumero
 {
   // Declaración de variables.
   private static int totalIntentos = 0;
   private static int numUsuario;
   private static int numCPU;
   private static bool intentoFallado = true;

   // Método para generar un número pseudoaleatorio.
   public static int CreaNumeroAleatorio()
   {
     Random aleatorio = new Random();

     int numAleatorio = aleatorio.Next(0, 101);

     return numAleatorio;
   }
   public static void Main(string[] args)
   {
     try
     {
       do
       {
         Console.WriteLine("JUEGO: AVIDINA EL NÚMERO");
         Console.WriteLine("Intenta adivinar un número entre 0 y 100.");
         Console.Write("Ingresa tu número: ");
         numUsuario = int.Parse(Console.ReadLine());
       } while (numUsuario < 0 || numUsuario > 100);

       // Se crea el número de la máquina.
       numCPU = CreaNumeroAleatorio();

       while (intentoFallado)
       {
         totalIntentos++;

         if (numUsuario < numCPU)
         {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("\nFALLASTE!!");
           Console.WriteLine("El número a adivinar es MAYOR.\n");
           Console.ResetColor();
           Console.Write("Prueba otra vez: ");
           numUsuario = int.Parse(Console.ReadLine());
         }
         else if (numUsuario > numCPU)
         {
           Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("\nFALLASTE!!");
           Console.WriteLine("El número a adivinar es MENOR.\n");
           Console.ResetColor();
           Console.Write("Prueba otra vez: ");
           numUsuario = int.Parse(Console.ReadLine());
         }
         else
         {
           // En caso de haber acertado el número de la CPU.
           Console.ForegroundColor = ConsoleColor.Green;
           Console.WriteLine("\nACERTASTE!!");
           Console.ResetColor();
           Console.WriteLine("Número de la CPU: {0}.", numCPU);
           Console.WriteLine("Número del usuario: {0}.", numUsuario);
           Console.WriteLine("Total de intentos: {0}.\n", totalIntentos);

           intentoFallado = false;
         }
       }
     }
     catch (Exception e)
     {
       Console.ForegroundColor = ConsoleColor.Yellow;
       Console.WriteLine("Excepción detectada: " + e.Message);
       Console.WriteLine("La próxima vez intenta poner números... Gracias.");
       Console.ResetColor();
     }


     // Invitación al usuario a salir del programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

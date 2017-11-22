/*
 * Programación101 - C# básico
 *
 * Escribe un programa que imprima los múltiplos de 3 del 1 al 1000.
 *
 * Autor: Unai de la O
 */

 using System;

 class ImprimeMultiplosDe3
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("\nMúltiplos de 3, del 1 al 1000:\n");
     for (int i = 1; i <= 1000; i++)
     {
       if (i % 3 == 0)
       {
         Console.WriteLine("[" + i + "]");
       }
     }
     Console.WriteLine("Pulse una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

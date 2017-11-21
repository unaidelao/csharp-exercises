/*
 * Programación101 - C# básico
 *
 * Escribir un programa que pida un número entero y pinte una pirámide de
 * rombos. Por ejemplo, si se introduce 6 la salida debe ser esta:
 *     *
 *     ***
 *     *****
 *     *******
 *     *********
 *     ***********
 *
 * Autor: Unai de la O
 */

 using System;

 class ImprimePiramide
 {
   public static void Main(string[] args)
   {
     int numUsuario;
     do
     {
       Console.Write("\nIntroduzca un número entero: ");
       numUsuario = int.Parse(Console.ReadLine());
     } while (numUsuario <= 0);

     int asteriscos = 1;

     for (int i = 0; i < numUsuario; i++)
     {
       for (int j = 0; j < asteriscos; j ++)
       {
         Console.Write("*");
       }
       Console.WriteLine();
       asteriscos += 2;
     }
     Console.WriteLine("Pulse una tecla para finalizar el programa...");
     Console.ReadKey();
   }
 }

/*
 * Programación101 - C# básico
 *
 * Escribe un programa que pregunte al usuario por números hasta que
 * introduzca 0 y luego escribir el mayor de estos.
 *
 * Autor: Unai de la O
 */

 using System;

 class PideNumerosUsuario
 {
   public static void Main(string[] args)
   {
     int numUsuario;
     int mayorNumeroDeTodos = 0;
     Console.WriteLine("\nEl siguiente programa irá pidiendo números " +
                       "hasta que se ingrese 0. Tras eso, se imprime " +
                       "por pantalla el mayor número introducido.\n");

     while (true)
     {
        Console.Write("Introduce un número: ");
        numUsuario = int.Parse(Console.ReadLine());
        if (numUsuario == 0)
        {
          Console.ForegroundColor = ConsoleColor.DarkYellow;
          Console.WriteLine("0 introducido --> No más números.");
          Console.ResetColor();
          break;
        }
        if (numUsuario > mayorNumeroDeTodos)
        {
          mayorNumeroDeTodos = numUsuario;
        }
     }
     Console.WriteLine("Mayor número ingresado: {0}", mayorNumeroDeTodos);

     Console.Write("Pulse una tecla para finalizar el programa...");
     Console.ReadKey();
   }
 }

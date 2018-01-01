/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que calcule el mayor de entre dos números. Para ello, haz un
 * método al que se le pase como parámetros esos dos números y devuelva el
 * mayor.
 *
 * Autor: Unai de la O.
 */

 using System;

 class ComparaDosNumeros
 {
   public static void ComparaNumeros (int a, int b)
   {
     Console.WriteLine("Números ordenados de mayor a menor:");
     Console.WriteLine(a < b ? a + " " + b : b + " " + a);
   }

   // MAIN y prueba del programa
   public static void Main(string[] args)
   {
     Console.WriteLine("Vamos a comparar dos números.");
     Console.Write("Introduce el primer número: ");
     int num1 = int.Parse(Console.ReadLine());
     Console.Write("Introduce el segundo número: ");
     int num2 = int.Parse(Console.ReadLine());

     ComparaNumeros(num1, num2);
   }
 }

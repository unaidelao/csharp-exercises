/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que compare tres números y los ordene de menor a mayor.
 *
 * Autor: Unai de la O.
 */

 using System;

 class ComparaTresNumeros
 {
   public static void ComparaNumeros (int a, int b, int c)
   {
     int tmp;

     if (a > b) {
       tmp = a;
       a = b;
       b = tmp;
     }
     if (a > c) {
       tmp = a;
       a = c;
       c = tmp;
     }
     if (b > c) {
       tmp = b;
       b = c;
       c = tmp;
     }
     Console.WriteLine("Números ordenados de menor a mayor:");
     Console.WriteLine("{0} , {1} , {2}", a, b, c);
   }

   // MAIN y prueba del programa
   public static void Main(string[] args)
   {
     Console.WriteLine("Vamos a comparar tres números.");
     Console.Write("Introduce el primer número: ");
     int num1 = int.Parse(Console.ReadLine());
     Console.Write("Introduce el segundo número: ");
     int num2 = int.Parse(Console.ReadLine());
     Console.Write("Introduce el tercer número: ");
     int num3 = int.Parse(Console.ReadLine());

     ComparaNumeros(num1, num2, num3);
   }
 }

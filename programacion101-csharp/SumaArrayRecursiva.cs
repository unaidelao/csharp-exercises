/*
 * Programación 101 - C# Básico
 *
 * Haz un método recursivo que permita sumar todos los elementos de un array
 * (int[] array), que vendrá pasada como parámetro.
 *
 * Autor: Unai de la O.
 */

 using System;

 class SumaArrayRecursiva
 {
   static int SumaRecursiva(int[] array, int n)
   {
     if (n == 0)
     {
       return array[n];
     }
     else
     {
       return array[n] + SumaRecursiva(array, n - 1);
     }
   }

   public static void Main(string[] args)
   {
     Console.Write("Introduce el número de elementos del array: ");
     int longitudArray = int.Parse(Console.ReadLine());

     int[] arrayPrueba = new int[longitudArray];

     Console.WriteLine("\nVamos a rellenar los datos de forma aleatoria...");
     Console.WriteLine("El resultado es el siguiente:\n");

     Random rand = new Random();
     for (int i = 0; i < longitudArray; i++)
     {
       arrayPrueba[i] = rand.Next(1, 101);
       Console.Write("[" + arrayPrueba[i] + "]" + "\t");
     }

     Console.WriteLine("Suma de los elementos del array: {0}",
     SumaRecursiva(arrayPrueba, longitudArray - 1));
   }
 }

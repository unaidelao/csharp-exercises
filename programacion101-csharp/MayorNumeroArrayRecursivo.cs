/*
 * Programación 101 - C# Básico
 *
 * Haz un método recursivo, que pasándole un array (int[] array) imprima el
 * mayor número dentro del array.
 *
 * Autor: Unai de la O.
 */

 using System;

 class MayorNumeroArrayRecursivo
 {
   static int MayorNumero(int[] array, int startIndex = 0)
   {
     // Valor actual.
     int actual = array[startIndex];

     // Caso base.
     if (startIndex + 1 == array.Length)
     {
         return actual;
     }

     // Recursión.
     int siguiente = MayorNumero(array, startIndex + 1);

     // Comparación.
     if (actual >= siguiente)
     {
         return actual;
     }

     return siguiente;
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

     Console.WriteLine("Mayor número (hallado con recursividad): {0}",
     MayorNumero(arrayPrueba));
   }
 }

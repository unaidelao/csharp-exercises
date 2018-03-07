/*
 * C# Basic Exercises.
 *
 * Write a C# program to multiply corresponding elements of two arrays of
 * integers.
 *
 * Author: Unai de la O
 */

 using System;

 public class MultiplyItemsArray
 {
   public static void Main(string[] args)
   {
     int[] array1 = {1, 6, -5, 1, -3};
     int[] array2 = {2, -4, -5, 2, 5};

     Console.WriteLine("Array 1: [{0}]", string.Join(", ", array1));
     Console.WriteLine("Array 2: [{0}]", string.Join(", ", array2));

     Console.Write("\nMultiply corresponding elements: [");
     for (int i = 0; i < array1.Length; i++)
     {
       if (i != array1.Length -1)
       {
         Console.Write(array1[i] * array2[i] + ", ");
       }
       else
       {
         Console.Write(array1[i] * array2[i]);
       }

     }
     Console.Write("]");
     Console.WriteLine();

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

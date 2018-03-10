/*
 * C# Basic Exercises.
 *
 * Write a C# program to print the odd numbers from 1 to 99. Prints one number
 * per line.
 *
 * Author: Unai de la O
 */

 using System;

 public class PrintOddNumbers
 {
   public static void Main(string[] args)
   {
     for (int i = 1; i < 100; i++)
     {
       if (i % 2 != 0)
       {
         Console.WriteLine(i);
       }
     }

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

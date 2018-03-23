/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given positive number is a multiple of 3 or
 * a multiple of 7.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckMultiple3or7
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a positive number, please: ");
     int num = int.Parse(Console.ReadLine());

     if (num <= 0)
     {
       Console.WriteLine("The provided number is not positive.");
       return;
     }
     else if (num % 3 == 0)
     {
       Console.WriteLine("Multiple of 3.");
     }
     else if (num % 7 == 0)
     {
       Console.WriteLine("Multiple of 7.");
     }
     else
     {
       Console.WriteLine("Not multiple of 3.\nNot multiple of 7.");
     }

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

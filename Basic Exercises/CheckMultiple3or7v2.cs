/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given positive number is a multiple of 3 or
 * a multiple of 7.
 *
 * Version: 2.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckMultiple3or7v2
 {
   public static bool CheckMult3or7(int n)
   {
     return (n % 3 == 0 || n % 7 == 0);
   }
   
   public static void Main(string[] args)
   {
     Console.Write("Enter a positive number, please: ");
     int num = int.Parse(Console.ReadLine());

     // Check if num is negative.
     if (num <= 0)
     {
       Console.WriteLine("The provided number is not positive.");
       return;
     }

     // Print result.
     Console.WriteLine(CheckMult3or7(num));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

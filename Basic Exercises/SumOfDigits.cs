/*
 * C# Basic Exercises.
 *
 * Write a C# program and compute the sum of the digits of an integer.
 *
 * Author: Unai de la O
 */

 using System;

 public class SumOfDigits
 {
   public static void Main(string[] args)
   {
     const int ASCII_CONVERT = 48;
     int result = 0;

     Console.Write("Enter an integer, please: ");
     string num = Console.ReadLine();

     char[] numChars = num.ToCharArray();

     foreach (char c in numChars) {
       int temp = Convert.ToInt32(c) - ASCII_CONVERT;
       result += temp;
     }

     Console.WriteLine("Sum of the digits: {0}", result);

     // End of program.
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

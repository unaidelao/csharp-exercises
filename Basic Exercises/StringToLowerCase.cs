/*
 * C# Basic Exercises.
 *
 * Write a C# program to convert a given string into lowercase.
 *
 * Author: Unai de la O
 */

 using System;

 public class StringToLowerCase
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a string, please: ");
     string str1 = Console.ReadLine();
     string str2 = str1.ToLower();
     Console.WriteLine("Result: {0}", str2);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

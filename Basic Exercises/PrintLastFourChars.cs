/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string of four copies, taking last four
 * characters from a given string. If the length of the given string is less
 * than 4 return the original one.
 *
 * Author: Unai de la O
 */

 using System;

 public class PrintLastFourChars
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a string, please: ");
     string userStr = Console.ReadLine();

     string[] arrStr = userStr.Split(' ');

     Console.Write("Result: ");

     if (arrStr[arrStr.Length -1].Length < 4)
     {
       Console.Write(userStr);
     }
     else
     {
       for (int i = 0; i < 4; i++)
       {
         Console.Write(arrStr[arrStr.Length -1] + " ");
       }
     }
     Console.WriteLine();

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

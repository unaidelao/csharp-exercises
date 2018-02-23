/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string from a given string where the
 * first and last characters will change their positions.
 *
 * Author: Unai de la O
 */

 using System;

 public class ChangeFirstAndLastChar
 {
   public static string Change(string str)
   {
     string result = "";
     string first = str.Substring(0, 1);
     string last = str.Substring(str.Length - 1);

     result = last + str.Substring(1, str.Length -2) + first;

     return result;
   }

   public static void Main(string[] args)
   {
     Console.Write("Please, enter a string: ");
     string userStr = Console.ReadLine();

     Console.Write("\nNow, applying the method, the result is: ");
     Console.WriteLine(Change(userStr));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

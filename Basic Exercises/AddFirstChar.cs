/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string from a given string with the first
 * character added at the front and back.
 *
 * Author: Unai de la O
 */

 using System;

 public class AddFirstChar
 {
   public static string AddChar(string str)
   {
     string result = "";
     string first = str.Substring(0, 1);

     result = first + str + first;

     return result;
   }

   public static void Main(string[] args)
   {
     Console.Write("Please, enter a string: ");
     string userStr = Console.ReadLine();

     Console.Write("\nNow, applying the method, the result is: ");
     Console.WriteLine(AddChar(userStr));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

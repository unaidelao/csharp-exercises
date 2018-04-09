/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string starts with "w" and
 * immediately followed by two "ww".
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckStartStringWWW
 {
   public static bool check(string str)
   {
     return str[0].Equals('w') && str[1].Equals('w') && str[2].Equals('w');
   }
   public static void Main(string[] args)
   {
     Console.Write("Enter a string: ");
     string userStr = Console.ReadLine();

     Console.WriteLine(check(userStr));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

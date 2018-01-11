/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print Hello and your name in a separate line.
 *
 * Author: Unai de la O
 */

 using System;

 public class HelloName
 {
   public static void Main(string[] args)
   {
     Console.Write("Please, enter your name: ");
     string userName = Console.ReadLine();

     Console.WriteLine("Hello {0}!!", userName);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

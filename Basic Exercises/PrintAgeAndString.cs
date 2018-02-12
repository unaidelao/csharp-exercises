/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program that takes an age (for example 20) as input and
 * prints something as "You look older than 20".
 *
 * Author: Unai de la O
 */

 using System;

 public class PrintAgeAndString
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter your age, please: ");
     int age = int.Parse(Console.ReadLine());

     Console.WriteLine("You look older than {0}", age);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

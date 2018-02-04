/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program that takes a number as input and print its
 * multiplication table.
 *
 * Author: Unai de la O
 */

 using System;

 public class MultiplicationTable
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("\nMULTIPLICATION TABLE");
     Console.WriteLine("--------------------");
     Console.Write("Enter a number: ");
     int num = int.Parse(Console.ReadLine());

     for (int i = 0; i <= 10; i++)
     {
       Console.WriteLine("{0} * {1} = {2}", num, i, num * i);
     }

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

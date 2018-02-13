/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program that takes four numbers as input to calculate and
 * print the average.
 *
 * Author: Unai de la O
 */

 using System;

 public class AverageOfFourNumbers
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter first number: ");
     int num1 = int.Parse(Console.ReadLine());

     Console.Write("Enter second number: ");
     int num2 = int.Parse(Console.ReadLine());

     Console.Write("Enter third number: ");
     int num3 = int.Parse(Console.ReadLine());

     Console.Write("Enter fourth number: ");
     int num4 = int.Parse(Console.ReadLine());

     int average = (num1 + num2 + num3 + num4) / 4;

     Console.WriteLine("The average of those numbers is {0}", average);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

/*
 * C# Basic Exercises.
 *
 * Write a C# program to get the absolute value of the difference between two
 * given numbers. Return double the absolute value of the difference if the
 * first number is greater than second number.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckIntCondition2
 {
   // x is the first number; y is the second number.
   public static int CheckInts(int x, int y)
   {
     if (x > y)
     {
       return Math.Abs(2 * (x - y));
     }
     else
     {
       return Math.Abs(x - y);
     }
   }
   public static void Main(string[] args)
   {
     Console.Write("Enter first int: ");
     int num1 = int.Parse(Console.ReadLine());

     Console.Write("Enter second int: ");
     int num2 = int.Parse(Console.ReadLine());

     Console.WriteLine("Check function: {0}", CheckInts(num1, num2));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

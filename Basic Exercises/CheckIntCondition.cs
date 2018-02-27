/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of two given integers. If two values
 * are equal, then return the triple of their sum.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckIntCondition
 {
   public static int CheckInts(int x, int y)
   {
     if (x == y)
     {
       return 3 * (x + y);
     }
     else
     {
       return x + y;
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

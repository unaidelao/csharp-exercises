/*
 * C# Basic Exercises.
 *
 * Write a C# program to check two given integers and return true if one is
 * negative and one is positive.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckPosNegInt
 {
   public static bool CheckInts(int x, int y)
   {
     if (x > 0 && y < 0 || x < 0 && y > 0)
     {
       return true;
     }
     else
     {
       return false;
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

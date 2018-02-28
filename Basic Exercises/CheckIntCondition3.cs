/*
 * C# Basic Exercises.
 *
 * Write a C# program to check the sum of the two given integers and return
 * true if one of the integer is 20 or if their sum is 20.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckIntCondition3
 {
   public static bool CheckInts(int x, int y)
   {
     if (x == 20 || y == 20 || x + y == 20)
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

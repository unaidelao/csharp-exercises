/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given integer is between 20 and 40.
 *
 * Author: Unai de la O
 */

 using System;

 public class CheckIntCondition4
 {
   public static bool CheckInt(int x)
   {
     if (x >= 20 && x <= 40)
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
     Console.Write("Enter an int: ");
     int num = int.Parse(Console.ReadLine());

     Console.WriteLine("Check function: {0}", CheckInt(num));

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

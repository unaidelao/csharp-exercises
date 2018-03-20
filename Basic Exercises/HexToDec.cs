/*
 * C# Basic Exercises.
 *
 * Write a C# program to convert a hexadecimal number to decimal number.
 *
 * Author: Unai de la O
 */

 using System;

 public class HexToDec
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a hexadecimal value: ");
     string hex = Console.ReadLine();
     int dec = Convert.ToInt32(hex, 16);
     Console.Write("Decimal value: {0}", dec);

     // End of program.
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

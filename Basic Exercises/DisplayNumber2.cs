/*
 * C# Basic Exercises.
 *
 * Write a C# program that takes a number as input and then displays a
 * rectangle of 3 columns wide and 5 rows tall using that digit.
 *
 * Author: Unai de la O
 */

 using System;

 public class DisplayNumber2
 {
   public static void Main(string[] args)
   {
     Console.Write("Please, enter a number: ");
     int number = int.Parse(Console.ReadLine());

     Console.WriteLine("{0}{0}{0}", number);
     Console.WriteLine("{0} {0}", number);
     Console.WriteLine("{0} {0}", number);
     Console.WriteLine("{0} {0}", number);
     Console.WriteLine("{0}{0}{0}", number);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

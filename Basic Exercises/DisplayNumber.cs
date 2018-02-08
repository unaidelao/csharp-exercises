/*
 * C# Basic Exercises.
 *
 * Write a C# program to that takes a number as input and display it four times
 * in a row (separated by blank spaces), and then four times in the next row,
 * with no separation. You should do it two times: Use Console. Write and then
 * use {0}.
 *
 * Author: Unai de la O
 */

 using System;

 public class DisplayNumber
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a number, please: ");
     int num = int.Parse(Console.ReadLine());

     Console.WriteLine("{0} {0} {0} {0}", num);
     Console.WriteLine("{0}{0}{0}{0}", num);
     Console.WriteLine("{0} {0} {0} {0}", num);
     Console.WriteLine("{0}{0}{0}{0}", num);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

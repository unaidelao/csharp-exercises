/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print the result of the specified operations:
 *     Operation 1: -1+4*6 --> 23
 *     Operation 2: (35+5)%7 --> 5
 *     Operation 3: 14 + -4 * 6 / 11 --> 12
 *     Operation 4: 2 + 15 / 6 * 1 - 7 % 2 --> 3
 *
 * Author: Unai de la O
 */

 using System;

 public class SpecifiedOperations
 {
   public static void Main(string[] args)
   {
     int operation1 = -1 + 4 * 6;
     int operation2 = (35 + 5) % 7;
     int operation3 = 14 + -4 * 6 / 11;
     int operation4 = 2 + 15 / 6 * 1 - 7 % 2;

     Console.WriteLine("Results of specified operations");
     Console.WriteLine("-------------------------------");
     Console.WriteLine("Operation 1: -1+4*6");
     Console.WriteLine("Result: {0}\n", operation1);

     Console.WriteLine("Operation 2: (35+5)%7");
     Console.WriteLine("Result: {0}\n", operation2);

     Console.WriteLine("Operation 3: 14 + -4 * 6 / 11");
     Console.WriteLine("Result: {0}\n", operation3);

     Console.WriteLine("Operation 4: 2 + 15 / 6 * 1 - 7 % 2");
     Console.WriteLine("Result: {0}\n", operation4);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

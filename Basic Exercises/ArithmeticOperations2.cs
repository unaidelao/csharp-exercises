/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to that takes three numbers(x,y,z) as input and
 * print the output of (x+y).z and x.y + y.z
 *
 * Author: Unai de la O
 */

 using System;

 public class ArithmeticOperations2
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter x number: ");
     int x = int.Parse(Console.ReadLine());

     Console.Write("Enter y number: ");
     int y = int.Parse(Console.ReadLine());

     Console.Write("Enter z number: ");
     int z = int.Parse(Console.ReadLine());

     int operation1 = (x + y) * z;
     int operation2 = (x * y) + (y * z);

     Console.WriteLine("\nResult of (x+y)*z: {0}", operation1);
     Console.WriteLine("Result of (x*y)+(y*z): {0}", operation2);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

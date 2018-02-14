/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print on screen the output of adding,
 * subtracting, multiplying and dividing of two numbers which will be entered
 * by the user.
 *
 * Author: Unai de la O
 */

 using System;

 public class ArithmeticOperations
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("\nLet's do some operations with two numbers...");
     Console.Write("Enter the first number: ");
     double n1 = double.Parse(Console.ReadLine());
     Console.Write("Now, enter the second number: ");
     double n2 = double.Parse(Console.ReadLine());

     Console.WriteLine("\nOutput:");
     Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
     Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
     Console.WriteLine("{0} * {1} = {2}", n1, n2, n1 * n2);
     Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2);
     Console.WriteLine("{0} mod {1} = {2}\n", n1, n2, n1 % n2);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

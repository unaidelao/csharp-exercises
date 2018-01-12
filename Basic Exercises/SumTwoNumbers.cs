/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print the sum of two numbers.
 *
 * Author: Unai de la O
 */

 using System;

 public class SumTwoNumbers
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("Let's sum two numbers.");
     Console.Write("Enter the first: ");
     int firstNum = int.Parse(Console.ReadLine());
     Console.Write("Now, enter the second: ");
     int secondNum = int.Parse(Console.ReadLine());
     Console.WriteLine("\nResult: {0} + {1} = {2}.\n",
     firstNum, secondNum, (firstNum + secondNum));

     // End of program
     Console.Write("Press any key to exit...");
     Console.ReadKey();
   }
 }

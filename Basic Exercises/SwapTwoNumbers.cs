/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to swap two numbers.
 *
 * Author: Unai de la O
 */

 using System;

 public class SwapTwoNumbers
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter the first number: ");
     int firstNum = int.Parse(Console.ReadLine());

     Console.Write("Enter the second number: ");
     int secondNum = int.Parse(Console.ReadLine());

     // Print data before swap.
     Console.WriteLine("\nBEFORE SWAP");
     Console.WriteLine("First Number: {0}", firstNum);
     Console.WriteLine("Second Number: {0}\n", secondNum);

     // Swap numbers.
     int temp = firstNum;
     firstNum = secondNum;
     secondNum = temp;

     // Print data after swap.
     Console.WriteLine("AFTER SWAP");
     Console.WriteLine("First Number: {0}", firstNum);
     Console.WriteLine("Second Number: {0}\n", secondNum);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

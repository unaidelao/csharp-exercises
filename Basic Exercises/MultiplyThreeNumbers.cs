/*
 * C# Basic Exercises
 *
 * Write a C# Sharp program to print the output of multiplication of three
 * numbers which will be entered by the user.
 *
 * Author: Unai de la O
 */

 using System;

 public class MultiplyThreeNumbers
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("Let's multiply three numbers...");
     Console.Write("Enter the first: ");
     int firstNum = int.Parse(Console.ReadLine());
     Console.Write("Now, enter the second: ");
     int secondNum = int.Parse(Console.ReadLine());
     Console.Write("Finally, enter the third: ");
     int thirdNum = int.Parse(Console.ReadLine());

     int result = firstNum * secondNum * thirdNum;

     Console.WriteLine("\nResult: {0}\n", result);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

/*
 * C# Basic Exercises.
 *
 * Write a C# program to check two given numbers where one is less than 100 and
 * other is greater than 200.
 *
 * Author: Unai de la O
 */

using System;

public class CheckGivenNumbers
{
  public static bool CheckFunction(int a, int b)
  {
    return (a < 100 && b > 100);
  }
  public static void Main(string[] args)
  {
    Console.Write("Enter first number: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.Write("Enter second number: ");
    int num2 = int.Parse(Console.ReadLine());

    // Result.
    Console.WriteLine(CheckFunction(num1, num2));

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

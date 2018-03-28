/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if an integer (from the two given integers) is
 * in the range -10 to 10.
 *
 * Author: Unai de la O
 */

using System;

public class CheckNumberRange
{
  public static bool CheckFunction(int a, int b)
  {
    return (a >= -10 && a <= 10) || (b >= -10 && b <= 10);
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

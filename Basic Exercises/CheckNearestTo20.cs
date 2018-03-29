/*
 * C# Basic Exercises.
 *
 * Write a C# program to check the nearest value of 20 of two given integers
 * and return 0 if two numbers are same.
 *
 * Author: Unai de la O
 */

using System;

public class CheckNearestTo20
{
  public static void Main(string[] args)
  {
    int value = 20;

    Console.Write("Enter first integer: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    int num2 = int.Parse(Console.ReadLine());

    if (Math.Abs(num1 - value) < Math.Abs(num2 - value))
    {
      Console.WriteLine(num1);
    }
    else if (Math.Abs(num2 - value) < Math.Abs(num1 - value))
    {
      Console.WriteLine(num2);
    }
    else
    {
      Console.WriteLine("0");
    }

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

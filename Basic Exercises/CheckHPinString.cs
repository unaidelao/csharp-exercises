/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if "HP" appears at second position in a string
 * and returns the string without "HP".
 *
 * Author: Unai de la O
 */

using System;

public class CheckHPinString
{
  public static void Main(string[] args) {

    Console.Write("Please, enter a string: ");
    string userStr = Console.ReadLine();

    if (userStr.Substring(1,2).Equals("HP"))
    {
      userStr = userStr.Remove(1,2);
      Console.WriteLine(userStr);
    }
    else
    {
      Console.WriteLine(userStr);
    }

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

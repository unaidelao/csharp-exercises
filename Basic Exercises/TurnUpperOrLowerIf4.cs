/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string where the first 4 characters will
 * be in lower case. If the string is less than 4 characters then make the
 * whole string in upper case.
 *
 * Author: Unai de la O
 */

using System;

public class TurnUpperOrLowerIf4
{
  public static void Main(string[] args)
  {
    string result = "";
    Console.Write("Enter a string: ");
    string userStr = Console.ReadLine();

    if (userStr.Length < 4)
    {
      result = userStr.ToUpper();
    }
    else
    {
      result = userStr.Substring(0, 4).ToLower() + userStr.Substring(4, userStr.Length -4);
    }

    // Print result.
    Console.WriteLine("Result: " + result);


    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

/*
 * C# Basic Exercises.
 *
 * Write a C# program to get a new string of two characters from a given
 * string. The first and second character of the given string must be "P" and
 * "H", so PHP will be "PH".
 *
 * Author: Unai de la O
 */

using System;

public class NewStringTwoChars
{
  public static void Main(string[] args)
  {
    Console.Write("Please, enter a string: ");
    string userStr = Console.ReadLine();
    var finalStr = "";

    if (userStr.Length >= 1 && userStr[0] == 'P')
    finalStr += userStr[0];
    if (userStr.Length >= 2 && userStr[1] == 'H')
    finalStr += userStr[1];

    if (finalStr.Equals("PH"))
    {
      Console.WriteLine(finalStr);
    }
    else
    {
      Console.WriteLine("Inserted string not suitable for this program!!");
    }

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

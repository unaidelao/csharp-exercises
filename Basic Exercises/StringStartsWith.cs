/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a string starts with a specified word.
 *
 * Author: Unai de la O
 */

using System;

public class StringStartsWith
{
  public static void Main(string[] args)
  {
    Console.Write("Please, enter a string: ");
    string userStr = Console.ReadLine();
    Console.Write("Now, enter the first word: ");
    string firstWord = Console.ReadLine();

    if (userStr.Trim().StartsWith(firstWord))
    {
      Console.WriteLine("Yes! The string starts with it!");
    }
    else
    {
      Console.WriteLine("No! The string does not start with it!");
    }

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

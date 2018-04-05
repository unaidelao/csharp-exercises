/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string contains ‘w’ character between
 * 1 and 3 times.
 *
 * Author: Unai de la O
 */

using System;

public class Check3wInString
{
  public static void Main(string[] args)
  {
    int counter = 0;

    Console.Write("Enter a string with, at least, one 'w': ");
    string userStr = Console.ReadLine();

    for (int i = 0; i < userStr.Length; i++)
    {
      if (userStr[i].Equals('w'))
      {
        counter++;
      }
    }

    if (counter >= 1 && counter <=3)
    {
      Console.WriteLine("Number of 'w' between 1 and 3.");
    }
    else
    {
      Console.WriteLine("Number of 'w' not between 1 and 3.");
    }

    // Print counter of 'w'
    Console.WriteLine("Total of 'w': " + counter);

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

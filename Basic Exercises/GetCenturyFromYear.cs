/*
 * C# Basic Exercises.
 *
 * Write a C# program to get the century from a year.
 *
 * Author: Unai de la O
 */

using System;

public class GetCenturyFromYear
{
  public static void Main(string[] args)
  {
    Console.Write("Enter a year, please: ");
    int year = int.Parse(Console.ReadLine());
    
    if (year < 0)
    {
      Console.WriteLine("Year must be > 0!!");
      return;
    }
    else {
      Console.WriteLine("The century is: {0}", getCentury(year));
    }

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static int getCentury(int year)
  {
    return (int)((year/100) + 1);
  }
}

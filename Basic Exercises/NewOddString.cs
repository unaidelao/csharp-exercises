/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new string of every other character
 * (odd position) from the first position of a given string.
 *
 * Author: Unai de la O
 */

using System;

public class NewOddString
{
  public static void Main(String[] args)
  {
    Console.Write("Enter a string, please: ");
    string strUser = Console.ReadLine();
    
    string strResult = CreateNewString(strUser);
    
    Console.WriteLine("Result: {0}", strResult);
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static string CreateNewString(string str)
  {
    string res = "";
    
    for (int i = 0; i < str.Length; i += 2)
    {
      res += str[i];
    }
    return res;
  }
}

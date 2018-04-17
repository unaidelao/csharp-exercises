/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a given string is a palindrome or not.
 *
 * Author: Unai de la O
 */

using System;

public class CheckPalindrome
{

  /*
   * MAIN
   */
  public static void Main(string[] args)
  {
    Console.Write("Enter a string: ");
    string text = Console.ReadLine();

    Console.WriteLine("Is a palindrome?: {0}", isPalindrome(text));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  
  /*
   * Returns all but the first and last letter of the String.
   */
  public static string middle(string s)
  {
    return s.Substring(1, s.Length -2);
  }


  /*
   * isPalindrome() method.
   */
  public static bool isPalindrome(string s)
  {

    if (s.Length <= 1)
    {
      return true;
    }
    if (!s[0].Equals(s[s.Length-1]))
    {
      return false;
    }
    else
    {
      //Console.WriteLine(middle(s));
      return isPalindrome(middle(s));
    }
  }
  
}

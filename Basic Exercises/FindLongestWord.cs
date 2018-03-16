/*
 * C# Basic Exercises.
 *
 * Write a C# program to find the longest word in a string.
 *
 * Author: Unai de la O
 */

 using System;

 public class FindLongestWord
 {
   // Method that searchs the longest word.
   // In case of several strings with the same length, returns the first.
   public static string findLongestWord(string[] arrStr)
   {
     int totalLength = 0;
     string result = "";

     foreach (string s in arrStr)
     {
       if (s.Length > totalLength)
       {
         totalLength = s.Length;
         result = s;
       }
     }

     return result;
   }
   public static void Main(string[] args)
   {
     Console.Write("Enter a string, please: ");
     string userStr = Console.ReadLine();

     string[] arrStr = userStr.Split(' ');

     string result = findLongestWord(arrStr);

     Console.WriteLine("\nUser string: {0}", userStr);
     Console.WriteLine("Longest word: {0}", result);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

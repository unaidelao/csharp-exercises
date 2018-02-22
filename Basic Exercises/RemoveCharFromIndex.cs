/*
 * C# Basic Exercises.
 *
 * Write a C# program remove specified a character from a non-empty string
 * using index of a character.
 *
 * Author: Unai de la O
 */

 using System;

 public class RemoveCharFromIndex
 {
   public static string removeChar(string str, int index)
   {
     return str.Remove(index, 1);
   }

   public static void Main(string[] args)
   {
     Console.Write("Please, enter a string: ");
     string str = Console.ReadLine();

     Console.Write("Now, enter the index to be removed: ");
     int index = int.Parse(Console.ReadLine());

     string strResult = removeChar(str, index);

     Console.WriteLine("Result: {0}", strResult);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

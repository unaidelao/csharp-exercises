/*
 * C# Basic Exercises.
 *
 * Write a C# program to reverse the words of a sentence.
 *
 * Author: Unai de la O
 */

 using System;

 public class ReverseSentence
 {
   public static void Main(string[] args)
   {
     Console.Write("Enter a sentence, please: ");
     string userStr = Console.ReadLine();

     string[] arrStr = userStr.Split(' ');

     for (int i = arrStr.Length -1; i >= 0; i--)
     {
       Console.Write(arrStr[i] + " ");
     }
     // End of program.
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

/*
 * C# Basic Exercises.
 *
 * Write a C# program to find the size of a specified file in bytes.
 *
 * Author: Unai de la O
 */

 using System;
 using System.IO;

 public class SizeOfFile
 {
   public static void Main(string[] args)
   {
     FileInfo f = new FileInfo("DisplayNumber2.cs");

     long sizeInBytes = f.Length;

     Console.WriteLine("Size of the file: {0}", sizeInBytes);

     // End of program.
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

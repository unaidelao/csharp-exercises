/*
 * C# Basic Exercises.
 *
 * Write a C# program to find the largest and lowest values from three integer
 * values.
 *
 * Author: Unai de la O
 */

using System;

public class FindLargestAndLowest
{
  public static void Main(string[] args)
  {
    int[] arr = new int[3];

    Console.Write("Enter fist integer: ");
    arr[0] = int.Parse(Console.ReadLine());
    Console.Write("Enter second integer: ");
    arr[1] = int.Parse(Console.ReadLine());
    Console.Write("Enter third integer: ");
    arr[2] = int.Parse(Console.ReadLine());

    Array.Sort(arr);

    Console.WriteLine("\nLowest: {0}\nLargest: {1}", arr[0], arr[2]);

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
}

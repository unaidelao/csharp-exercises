/*
 * C# Basic Exercises.
 *
 * Write a C# program to count a specified number in a given array of integers.
 *
 * Author: Unai de la O
 */

using System;

public class CountSpecifiedNumberInArray
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 20 int element array.
    int[] numArray = new int[20];
    
    // Initializes numArray with random numbers between 1 and 10.
    for (int i = 0; i < numArray.Length; i++)
    {
      numArray[i] = rand.Next(1, 11);
    }
    
    // Print numArray.
    Console.WriteLine("Aleatory example array:");
    
    foreach (int x in numArray)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    // Ask user a number.
    Console.Write("Enter a number: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    // Print result.
    Console.WriteLine("Total of {0} in array: {1}", num, countNumbers(numArray, num));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static int countNumbers(int[] arr, int n)
  {
    int result = 0;
    
    foreach (int a in arr)
    {
      if (a == n)
      {
        result++;
      }
    }
    return result;
  }
    
}

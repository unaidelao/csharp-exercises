/*
 * C# Basic Exercises.
 *
 * Write a C# program to get the larger value between first and last element of
 * an array of integers.
 *
 * Author: Unai de la O
 */

using System;

public class LargestIntArrayElement
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 10 int element array.
    int[] numArray = new int[10];
    
    // Initializes numArray with random numbers between 1 and 99.
    for (int i = 0; i < numArray.Length; i++)
    {
      numArray[i] = rand.Next(1, 100);
    }
    
    // Print numArray.
    Console.WriteLine("Random array:");
    
    foreach (int x in numArray)
    {
      Console.Write("{0,2:0} ", x);
    }
    Console.WriteLine();
    Console.WriteLine();
    
    // Print result.
    Console.WriteLine("Largest element: {0}", largest(numArray));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static int largest(int[] arr)
  {
    int result = 0;
    foreach (int e in arr)
    {
      if (e > result)
      {
        result = e;
      }
    }
    return result;
  }
    
}


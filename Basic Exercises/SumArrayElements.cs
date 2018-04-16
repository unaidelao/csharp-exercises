/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of all the elements of an array of
 * integers.
 *
 * Author: Unai de la O
 */

using System;

public class SumArrayElements
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 5 int element array.
    int[] numArray = new int[5];
    
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
    
    // Print sum.
    Console.WriteLine("Sum of array elements: {0}", sumElements(numArray));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static int sumElements(int[] arr)
  {
    int result = 0;
    
    foreach (int n in arr)
    {
      result += n;
    }
    return result;
  }
  
}

/*
 * C# Basic Exercises.
 *
 * Write a C# program to find the pair of adjacent elements that has the
 * largest product of an given array.
 *
 * Author: Unai de la O
 */

using System;

public class FindPairWithLargestProduct
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 10 int element array.
    int[] numArray = new int[10];
    
    // Initializes numArray with random numbers between 1 and 10.
    for (int i = 0; i < numArray.Length; i++)
    {
      numArray[i] = rand.Next(1, 11);
    }
    
    // Print numArray.
    Console.WriteLine("Random array:");
    
    foreach (int x in numArray)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    // Print result.
    Console.WriteLine("Largest pair: {0}", findLargestPair(numArray));

    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static string findLargestPair(int[] arr)
  {
    int num1 = 0; 
    int num2 = 0;
    int product = 0;
    
    for (int i = 0; i < arr.Length -1; i++)
    {
      if ((arr[i] * arr[i+1]) > product)
      {
        num1 = arr[i];
        num2 = arr[i+1];
        product = num1 * num2;
      }
    }
    string result = String.Format("[{0},{1}]", num1, num2);
    return result;
  }
  
}


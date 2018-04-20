/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if the first element and the last element
 * are equal of an array of integers and the length is 1 or more.
 *
 * Author: Unai de la O
 */

using System;

public class NumberIsFirstAndLastInArray
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
    Console.WriteLine("Aleatory example array:");
    
    foreach (int x in numArray)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    // Print result.
    Console.WriteLine("First and Last are the same?: {0}", checkNum(numArray));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static bool checkNum(int[] arr)
  {
    return (arr.Length >= 1) && (arr[0].Equals(arr[arr.Length -1])); 
  }
    
}

/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if the first element or the last element of
 * the two arrays ( length 1 or more) are equal.
 *
 * Author: Unai de la O
 */

using System;

public class NumberIsFirstOrLastInTwoArrays
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
    Console.WriteLine("Aleatory array 1:");
    
    foreach (int x in numArray)
    {
      Console.Write("{0,2:0} ", x);
    }
    Console.WriteLine();
    
    // Second array.
    int[] numArray2 = new int[10];
    
    // Initializes numArray2 with random numbers between 1 and 10.
    for (int i = 0; i < numArray2.Length; i++)
    {
      numArray2[i] = rand.Next(1, 11);
    }
    
    // Print numArray1.
    Console.WriteLine("Aleatory array 2:");
    
    foreach (int x in numArray2)
    {
      Console.Write("{0,2:0} ", x);
    }
    Console.WriteLine();
    Console.WriteLine();
    
    
    // Print result.
    Console.WriteLine("First or last element of given arrays are equal: {0}", checkArrays(numArray, numArray2));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static bool checkArrays(int[] arr, int[] arr2)
  {
    return (arr.Length >=1 && arr2.Length >=1) &&
    (arr[0].Equals(arr2[0]) || arr[arr.Length -1].Equals(arr2[arr2.Length -1])); 
  }
    
}

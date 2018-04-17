/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if an array contains an odd number.
 *
 * Author: Unai de la O
 */

using System;

public class CheckOddNumberInArray
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 3 int element array.
    int[] numArray = new int[3];
    
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
    Console.WriteLine();
    
    // Print result.
    Console.WriteLine("Does Array1 contain an odd number?: {0}", check(numArray));
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  // Method that checks if an array contains an odd number.
  public static bool check(int[] arr)
  {
    foreach (int e in arr)
    {
      // if even
      if (e % 2 != 0)
      {
        return true;
      }
    }
    return false;
  }
      
}


/*
 * C# Basic Exercises.
 *
 * Write a C# program which will accept a list of integers and checks how many
 * integers are needed to complete the range.
 *
 * Author: Unai de la O
 */

using System;

public class TotalIntsToCompleteTheRange
{

  public static void Main(string[] args)
  {
    // Required variables.
    int rangeNumbers, presentNumbers;
    
    // Example array.
    int[] arr = {1, 3, 4, 5, 10, 13, 15}; // 8 missing elements
    
    // Print numArray.
    Console.WriteLine("Example array:");
    
    foreach (int x in arr)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    
    // Compute result.
    rangeNumbers = arr[arr.Length-1] - arr[0] + 1;
    presentNumbers = arr.Length;
    
    
    // Print result.
    Console.WriteLine("Total numbers to complete the range: {0}",
    rangeNumbers - presentNumbers);
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
    
}

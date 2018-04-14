/*
 * C# Basic Exercises.
 *
 * Write a C# program to check if a number appears as either the first or
 * last element of an array of integers and has at least two digits.
 *
 * Author: Unai de la O
 */

using System;

public class NumberIsFirstOrLastInArray
{
  public static void Main(string[] args)
  {
    // Random instance.
    Random rand = new Random();
    
    // For example, declare a 20 int element array.
    int[] numArray = new int[20];
    
    // Initializes numArray with random numbers between 1 and 100.
    for (int i = 0; i < numArray.Length; i++)
    {
      numArray[i] = rand.Next(1, 101);
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
    Console.WriteLine("Is {0} first or last in array and has at least 2 digits?: {1}", num, checkNum(numArray, num));
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static bool checkNum(int[] arr, int n)
  {
    return (n > 9) && (arr[0].Equals(n) || arr[arr.Length -1].Equals(n)); 
  }
    
}

/*
 * C# Basic Exercises.
 *
 * Write a C# program to create a new array of length containing the middle
 * elements of three arrays (each length 3) of integers.
 *
 * Author: Unai de la O
 */

using System;

public class NewArrayMiddleElements
{
  public static void Main(string[] args)
  {
    // Max array length.
    const int MAX_LENGTH = 3;
    
    // Random instance.
    Random rand = new Random();
    
    // Generate three random arrays.
    int[] randArr1 = generateRandomArray(rand, MAX_LENGTH);
    int[] randArr2 = generateRandomArray(rand, MAX_LENGTH);
    int[] randArr3 = generateRandomArray(rand, MAX_LENGTH);
    
    // Print arrays.
    Console.Write("Random array1:");
    printArray(randArr1);
    Console.Write("Random array2:");
    printArray(randArr2);
    Console.Write("Random array3:");
    printArray(randArr3);
    
    // The final array.
    int[] resultArray = middleElementsArray(randArr1, randArr2, randArr3);
    Console.Write("Result:");
    printArray(resultArray);
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  
  // Method that generates a random array of 3 elements.
  public static int[] generateRandomArray(Random rnd, int MAX)
  {
    
    int[] arr = new int[MAX];
    
    // Initializes numArray with random numbers between 1 and 10.
    for (int i = 0; i < MAX; i++)
    {
      arr[i] = rnd.Next(1, 11);
    }
    return arr;
  }
  
  
  // Print array method.
  public static void printArray(int[] arr)
  {
    foreach (int e in arr)
    {
      Console.Write("{0,2:0} ", e);
    }
    Console.WriteLine();
    Console.WriteLine();
  }
  
  
  // Method that creates an array with the middle elements of another three.
  public static int[] middleElementsArray(int[] arr1, int[] arr2, int[] arr3)
  {
    int[] result = {arr1[1], arr2[1],arr3[1]};
    return result;
  }
    
}


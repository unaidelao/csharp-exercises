/*
 * C# Basic Exercises.
 *
 * Write a C# program to rotate an array (length 3) of integers in left
 * direction.
 *
 * Author: Unai de la O
 */

using System;

public class RotateArray
{
  public static void Main(string[] args)
  {
    // Ask user a number.
    Console.WriteLine("Please, enter 3 integers! ");
    Console.Write("First number: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.Write("Second number: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.Write("Third number: ");
    int num3 = int.Parse(Console.ReadLine());
    Console.WriteLine();
    
    // Create array.
    int[] array1 = {num1, num2, num3};
    
    // Print numArray.
    Console.WriteLine("Original array:");
    
    foreach (int x in array1)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    int[] rotatedArray = rotate(array1);
    
    // Print result.
    Console.WriteLine("Rotated array:");
    foreach (int x in rotatedArray)
    {
      Console.Write(x + " ");
    }
    Console.WriteLine();
    Console.WriteLine();
    
    // End of program
    Console.Write("\nPress any key to exit...");
    Console.ReadKey();
  }
  
  public static int[] rotate(int[] arr)
  {
    int[] result = {arr[1], arr[2], arr[0]};
    return result;
  }
    
}


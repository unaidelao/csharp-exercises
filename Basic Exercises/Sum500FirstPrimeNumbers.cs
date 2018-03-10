/*
 * C# Basic Exercises.
 *
 * Write a C# program to compute the sum of the first 500 prime numbers.
 * per line.
 *
 * Author: Unai de la O
 */

 using System;

 public class Sum500FirstPrimeNumbers
 {
   // Method that checks if a number is prime.
   public static bool IsPrime(int n)
   {
     if (n <= 1)
     {
       return false;
     }
     if (n == 2)
     {
       return true;
     }

     if (n % 2 == 0)
     {
       return false;
     }

     int nSqrt = (int)Math.Sqrt(n);

     for (int divisor = 3; divisor <= nSqrt; divisor += 2)
     {
       if (n % divisor == 0)
       {
         return false;
       }
     }
     return true;
   }
   // MAIN
   public static void Main(string[] args)
   {
     int result = 0;

     for (int i = 0; i <= 500; i++)
     {
       if (IsPrime(i))
       {
         result += i;
       }
     }

     Console.WriteLine(result);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

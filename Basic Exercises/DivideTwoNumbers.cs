/*
 * C# Basic Exercises.
 *
 * Write a C# Sharp program to print the quotient of two numbers.
 *
 * Author: Unai de la O
 */

 using System;

 public class DivideTwoNumbers
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("Let's divide two numbers.");
     Console.Write("Enter the first: ");
     double firstNum = double.Parse(Console.ReadLine());
     Console.Write("Now, enter the second: ");
     double secondNum = double.Parse(Console.ReadLine());

     // Check divisions by 0.
     if (firstNum == 0 && secondNum == 0)
     {
       Console.WriteLine("Undefined result: 0/0!!\n");
       return;
     }
     if (secondNum == 0)
     {
       Console.Write("Error: division by 0 not allowed!!\n");
       return;
     }

     // Print result.
     Console.WriteLine("\nResult: {0} / {1} = {2}.\n",
     firstNum, secondNum, (firstNum / secondNum));

     // End of program.
     Console.Write("Press any key to exit...");
     Console.ReadKey();
   }
 }

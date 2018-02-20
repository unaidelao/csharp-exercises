/*
 * C# Basic Exercises.
 *
 * Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
 *
 * Author: Unai de la O
 */

 using System;

 public class TemperatureConverter
 {
   public static void Main(string[] args)
   {
     Console.Write("Please, enter celsius: ");
     int celsius = int.Parse(Console.ReadLine());
     int kelvin = celsius + 273;
     int fahrenheit = celsius * 18 / 10 + 32;

     Console.WriteLine("\n{0} celsius = {1} kelvin", celsius, kelvin);
     Console.WriteLine("{0} celsius = {1} fahrenheit", celsius, fahrenheit);

     // End of program
     Console.Write("\nPress any key to exit...");
     Console.ReadKey();
   }
 }

/*
 * Programación 101 - C# Básico
 *
 * Haz que el programa anterior (NumeroAlReves.cs) saque el número invertido
 * más 10.
 *
 * Autor: Unai de la O.
 */
 using System;

 class NumeroAlRevesMas10
 {
   public static void Main(string[] args)
   {
     Console.Write("Introduce un número entero: ");
     int num = int.Parse(Console.ReadLine());
     int numAlReves = 0;
     int temp = 0;

     while (num != 0)
     {
       temp = num % 10;
       numAlReves = numAlReves * 10 + temp;
       num /= 10;
     }

     numAlReves += 10;

     Console.WriteLine("Número al revés: {0}", numAlReves);
   }
 }

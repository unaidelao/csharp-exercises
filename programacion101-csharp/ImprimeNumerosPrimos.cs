/*
 * Programación101 - C# básico
 *
 * Escribir un programa que imprima todos los números primos que se encuentran
 * entre 1 y 1000.
 *
 * Autor: Unai de la O
 */
 
 using System;
 
 class ImprimeNumerosPrimos
 {
   // Método para saber si un número es primo.
   public static bool EsPrimo(int n)
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
   public static void Main(string[] args)
   {
     Console.WriteLine("Los números primos entre 1 y 1000 son:");
     for (int i = 0; i < 1000; i++)
     {
       if (EsPrimo(i))
       {
         Console.WriteLine(i);
       }
     }
   }
 }
/*
 * Programación 101 - C# Básico
 *
 * Rellena un array con los 25 primeros números primos. Luego muestra la suma
 * de todos ellos.
 *
 * Autor: Unai de la O.
 */

using System;

class SumaNumerosPrimos
{
  public static void Main(string[] args)
  {
    const int MAX_SIZE = 25;
    int[] arrayPrimos = new int[MAX_SIZE];
    // Variable que contará el número de primos encontrados.
    int contador = 0;
    // Variable que recoge el valor del número a contrastar si es primo.
    int numero = 2;
    // Iterador del bucle.
    int i = 0;

    // Se rellena el array con los primeros 25 números primos.
    while (contador != MAX_SIZE)
    {
      if (IsPrime(numero))
      {
        arrayPrimos[i] = numero;
        i++;
        numero++;
        contador++;
      }
      else
      {
        numero++;
      }
    }

    // Se calcula la suma de todos ellos.
    int totalSuma = 0;
    foreach (int num in arrayPrimos)
    {
      totalSuma += num;
    }
    Console.WriteLine("La suma de los 25 primeros números primos es {0}",
    totalSuma);

    // Imprimo el contenido del arrayPrimos.
    Console.WriteLine("\nContenido del array");
    Console.WriteLine("-------------------");
    foreach (int num in arrayPrimos)
    {
      Console.Write(num + " ");
    }

    // Invitación al usuario a finalizar el programa.
    Console.Write("\n\nFin del programa. Pulse una tecla para salir...");
    Console.ReadKey();
  }

  /*
   * Función recuperada de otro ejercicio que devuelve true si detecta un
   * número primo.
   */
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
}

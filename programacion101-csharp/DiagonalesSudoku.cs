/*
 * Programación 101 - C# Básico
 *
 * Crea un array de 3x3 como si fuera una celda de un Sudoku con datos que
 * introduzca el usuario. Una vez esté, suma el resultado de las dos diagonales
 * e imprímelo.
 *
 * Autor: Unai de la O.
 */

 using System;

 class DiagonalesSudoku
 {
   public static void Main(string[] args)
   {
     // Constante para la longitud de la matriz.
     const int longitud = 3;
     // Declaración del array de 3x3.
     int[,] sudoku = new int[longitud,longitud];

     // Se pide al usuario que rellene el array.
     Console.WriteLine("Vamos a rellenar un array de 3x3");

     for (int i = 0; i < longitud; i++)
     {
       for (int j = 0; j < longitud; j++)
       {
         Console.Write("Valor de la celda [{0},{1}]: ", i, j);
         sudoku[i,j] = int.Parse(Console.ReadLine());
       }
     }

     // Imprimir el array.
     Console.WriteLine("\nMatriz tipo sudoku impresa.");
     for (int i = 0; i < longitud; i++)
     {
       for (int j = 0; j < longitud; j++)
       {
         Console.Write("[" + sudoku[i,j] + "]" + " ");
       }
       Console.WriteLine();
     }

     // Suma de las diagonales.
     int sumaDiagonal1 = 0;
     int sumaDiagonal2 = 0;

     for (int i = 0; i < longitud; i++)
     {
       for (int j = 0; j < longitud; j ++)
       {
         if (i == j)
         {
           sumaDiagonal1 += sudoku[i,j];
         }
         if (i + j == longitud - 1)
         {
           sumaDiagonal2 += sudoku[i,j];
         }
       }
     }

     // Resultado.
     Console.WriteLine("Suma de la primera diagonal: {0}", sumaDiagonal1);
     Console.WriteLine("Suma de la segunda diagonal: {0}", sumaDiagonal2);
     Console.WriteLine("Suma de las dos diagonales: {0}",
     sumaDiagonal1 + sumaDiagonal2);
   }
 }

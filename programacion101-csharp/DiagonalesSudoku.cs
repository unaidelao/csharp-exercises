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
     // Declaración del array de 3x3.
     int[,] sudoku = new int[3,3];

     // Se pide al usuario que rellene el array.
     Console.WriteLine("Vamos a rellenar un array de 3x3");

     for (int i = 0; i < 3; i++)
     {
       for (int j = 0; j < 3; j++)
       {
         Console.Write("Valor de la celda [{0},{1}]: ", i, j);
         sudoku[i,j] = int.Parse(Console.ReadLine());
       }
     }

     // DEBUG: imprimir el array
     foreach (int n in sudoku)
     {
       Console.Write("[" + n + "]" + " ");
     }

     // Falta imprimir la suma de las dos diagonales.
   }
 }

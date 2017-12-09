/*
 * Programación 101 - C# Básico
 *
 * Pide al usuario 10 números y almacénalos en un array. Luego sácalos por
 * pantalla ordenados.
 *
 * Autor: Unai de la O.
 */

 using System;

 class OrdenaArrayInt
 {
   public static void Main(string[] args)
   {
     const int LONGITUD = 10;

     int[] numeros = new int[LONGITUD];

     Console.WriteLine("Rellena un array con 10 números enteros.");
     Console.WriteLine("Introduce los números de uno en uno:");

     // Rellenar el array con números del usuario.
     for (int i = 0; i < LONGITUD; i++)
     {
       numeros[i] = int.Parse(Console.ReadLine());
     }

     // Imprimir el array tal cual está.
     Console.WriteLine("Array desordenado.");
     foreach (int num in numeros)
     {
       Console.Write("[" + num + "] ");
     }
     Console.WriteLine();

     // Ordenar el array.
     Array.Sort(numeros);

     //Imprimir el array ya ordenado.
     Console.WriteLine("Array ordenado.");
     foreach (int num in numeros)
     {
       Console.Write("[" + num + "] ");
     }
     Console.WriteLine();


     // Invitación al usuario a finalizar el programa.
     Console.WriteLine("Pulse una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

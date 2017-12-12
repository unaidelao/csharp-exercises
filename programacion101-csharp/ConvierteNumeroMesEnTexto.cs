/*
 * Programación 101 - C# Básico
 *
 * Haz un programa en el que el usuario introduzca el número de mes (1/12) y el
 * programa lo convierta a texto (P. Ej.: 11 => Noviembre).
 *
 * Autor: Unai de la O.
 */

 using System;

 class ConvierteNumeroMesEnTexto
 {
   public static void Main(string[] args)
   {
     Console.Write("Introduce un número del 1 al 12: ");
     int inputUsuario = int.Parse(Console.ReadLine());

     switch (inputUsuario)
     {
       case 1:
         Console.WriteLine("Enero.");
         break;
       case 2:
         Console.WriteLine("Febrero");
         break;
       case 3:
         Console.WriteLine("Marzo");
         break;
       case 4:
         Console.WriteLine("Abril.");
         break;
       case 5:
         Console.WriteLine("Mayo.");
         break;
       case 6:
         Console.WriteLine("Junio.");
         break;
       case 7:
         Console.WriteLine("Julio");
         break;
       case 8:
         Console.WriteLine("Agosto.");
         break;
       case 9:
         Console.WriteLine("Septiembre.");
         break;
       case 10:
         Console.WriteLine("Octubre.");
         break;
       case 11:
         Console.WriteLine("Noviembre.");
         break;
       case 12:
         Console.WriteLine("Diciembre.");
         break;
       default:
         Console.WriteLine("Número no válido.");
         break;
     }
   }
 }

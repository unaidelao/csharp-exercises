/*
 * Programación 101 - C# Básico
 *
 * Haz que el usuario introduzca un mes (1/12) e imprime si este tiene 31, 30 o
 * 28 días. Pista: Puedes agrupar más de un case.
 *
 * Autor: Unai de la O.
 */

 using System;

 class CantidadDiasMes
 {
   public static void Main(string[] args)
   {
     int mes;

     do
     {
       Console.Write("Introduce un número de mes (del 1 al 12): ");
       mes = int.Parse(Console.ReadLine());
     } while (mes < 1 || mes > 12);

     switch (mes)
     {
       case 1:
       case 3:
       case 5:
       case 7:
       case 8:
       case 10:
       case 12:
         Console.WriteLine("El mes indicado tiene 31 días.");
         break;
       case 4:
       case 6:
       case 9:
       case 11:
         Console.WriteLine("El mes indicado tiene 30 días.");
         break;
       case 2:
         Console.WriteLine("El mes indicado tiene 28 días... a no ser que " +
         "se trate de un año bisiesto.");
         break;
     }

     // Invitación al usuario a salir del programa.
     Console.WriteLine("Pulse una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

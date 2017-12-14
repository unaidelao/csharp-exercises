/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que lea una fecha completa (4/11/2016) y la convierta en
 * texto: (4 de noviembre de 2016).
 *
 * PISTA: Usa String.Split
 *
 * Autor: Unai de la O.
 */

 using System;

 class ImprimeFechaEnString
 {
   public static void Main(string[] args)
   {
     Console.Write("Introduce una fecha (por ej. 03/10/2017): ");
     string fechaUsuario = Console.ReadLine();

     string[] fechaArrStr = fechaUsuario.Split('/');

     /*
      * Imprime por pantalla el resultado según la comparación con el mes cuyo
      * valor se encuentra en fechaArrStr[1].
      */
     switch (fechaArrStr[1])
     {
       case "1":
       case "01":
         Console.WriteLine("{0} de enero de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "2":
       case "02":
         Console.WriteLine("{0} de febrero de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "3":
       case "03":
         Console.WriteLine("{0} de marzo de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "4":
       case "04":
         Console.WriteLine("{0} de abril de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "5":
       case "05":
         Console.WriteLine("{0} de mayo de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "6":
       case "06":
         Console.WriteLine("{0} de junio de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "7":
       case "07":
         Console.WriteLine("{0} de julio de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "8":
       case "08":
         Console.WriteLine("{0} de agosto de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "9":
       case "09":
         Console.WriteLine("{0} de septiembre de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "10":
         Console.WriteLine("{0} de octubre de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "11":
         Console.WriteLine("{0} de noviembre de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       case "12":
         Console.WriteLine("{0} de diciembre de {1}.", fechaArrStr[0], fechaArrStr[2]);
         break;
       default:
         Console.WriteLine("Número no válido.");
         break;
     }
   }
 }

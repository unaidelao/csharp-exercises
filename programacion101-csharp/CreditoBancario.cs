/*
 * Programación 101 - C# Básico
 *
 * Un banco nos ha dado un crédito de 1200€ durante un año. Crea un programa
 * que calcule el 3% de cada mensualidad, que es la comisión que se llevará el
 * banco.
 *
 * Crea un método en el cual se introduzca la mensualidad y el interés como
 * parámetros (120€ y 3%) y devuelva la cantidad con el porcentaje aplicado
 * (123,6€). Este método tiene que funcionar para cualquier cantidad y
 * porcentaje.
 *
 * Autor: Unai de la O.
 */

 using System;

 class CreditoBancario
 {
   public static void Main(string[] args)
   {
     double cantidadPrestada = 1200;
     double intereses = 0.03;
     double mensualidad = cantidadPrestada / 12;
     double comision = mensualidad * intereses;

     double pagoTotalMes = totalMensualidad(mensualidad, intereses);

     Console.WriteLine("Cantidad prestada: {0} euros.", cantidadPrestada);
     Console.WriteLine("Interés: {0}%", intereses * 100);
     Console.WriteLine("Mensualidad sobre el crédito: {0} euros.", mensualidad);
     Console.WriteLine("Total a pagar mensualmente: {0} euros.", pagoTotalMes);

     // Invitación al usuario a finalizar el programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }

   // Parámetros: mensualidad (m), interés (i).
   public static double totalMensualidad(double m, double i)
   {
     return m + (m * i);
   }
 }

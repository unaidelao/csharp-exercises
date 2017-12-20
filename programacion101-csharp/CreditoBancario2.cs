/*
 * Programación 101 - C# Básico
 *
 * Extendiendo el programa anterior (CreditoBancario.cs), crea un nuevo método
 * dónde introduzcas el importe total, el número de meses a pagar y el
 * porcentaje del banco, y, extendiendo el método anterior, sea capaz de
 * calcular e imprimir el importe de la cuota mensual.
 *
 * Autor: Unai de la O.
 */
 using System;

 class CreditoBancario2
 {
   public static void Main(string[] args)
   {
     Console.WriteLine("INTRODUCE LOS DATOS DEL PRÉSTAMO:");
     Console.Write("Importe total del préstamo: ");
     double cantidadPrestada = double.Parse(Console.ReadLine());

     Console.Write("Número de meses a pagar:");
     double meses = double.Parse(Console.ReadLine());

     Console.Write("Intereses del Banco: ");
     double interes = double.Parse(Console.ReadLine()) / 100;

     double mensualidades = cantidadPrestada / meses;

     double comision = mensualidades * interes;

     double pagoTotalMes = totalMensualidad(mensualidades, interes) + comision;

     Console.WriteLine("\nCantidad prestada: {0} euros.", cantidadPrestada);
     Console.WriteLine("Interés: {0}%", interes * 100);
     Console.WriteLine("Mensualidad sobre el crédito: {0} euros.", mensualidades);
     Console.WriteLine("Total a pagar mensualmente: {0} euros.", pagoTotalMes);

     // Invitación al usuario a finalizar el programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }

   // Parámetros: mensualidades (m), interés (i).
   public static double totalMensualidad(double m, double i)
   {
     return m + (m * i);
   }
 }

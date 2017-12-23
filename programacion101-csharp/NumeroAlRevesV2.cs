/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que contenga un método que invierta un número. Por ejemplo,
 * si el usuario introduce 239874 la salida tiene que ser 478932.
 *
 * Usa el método dos veces, y si lo has hecho bien debería salir el número
 * original.
 *
 * Versión 2.0
 *
 * Autor: Unai de la O.
 */

 using System;
 using System.Text;

 class NumeroAlRevesV2
 {
   public static int ReverseSeq(int num)
   {
     int temp = 0;
     int numAlReves = 0;

     while (num != 0)
     {
       temp = num % 10;
       numAlReves = numAlReves * 10 + temp;
       num /= 10;
     }
     return numAlReves;
   }

   public static void Main(string[] args)
   {
     Console.Write("Introduce un número entero: ");
     int numUsuario = int.Parse(Console.ReadLine());
     int numAlReves = ReverseSeq(numUsuario);

     Console.WriteLine("Número al revés: {0}", numAlReves);

     // Final del programa
     Console.Write("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

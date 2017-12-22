/*
 * Programación 101 - C# Básico
 *
 * Haz un programa que contenga un método que invierta un número. Por ejemplo,
 * si el usuario introduce 239874 la salida tiene que ser 478932.
 *
 * Usa el método dos veces, y si lo has hecho bien debería salir el número
 * original.
 *
 * Autor: Unai de la O.
 */
 using System;

 class NumeroAlReves
 {
   public static void Main(string[] args)
   {
     Console.Write("Introduce un número entero: ");
     int num = int.Parse(Console.ReadLine());
     int numAlReves = 0;
     int temp = 0;

     while (num != 0)
     {
       temp = num % 10;
       numAlReves = numAlReves * 10 + temp;
       num /= 10;
     }

     Console.WriteLine("Número al revés: {0}", numAlReves);
   }
 }

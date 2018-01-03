/*
 * Programación 101 - C# Básico
 *
 * Haz un método que calcule el consumo de un coche en autovía. El coche
 * consume 5,8l/100km. El programa debe ser capaz de operar en kilómetros y en
 * millas.
 *
 * Si todo es correcto, para 50km debería salir un consumo de 2.9l y para 50
 * millas debería salir un consumo de aprox 4.67l.
 *
 * Autor: Unai de la O.
 */

 using System;

 class ConsumoCocheAutovia
 {
   public static void Main(string[] args)
   {
     // Lo más apto es guardar el consumo en litros por cada kilómetro.
     double consumo = 0.058;

     char respuestaMillas;

     // Pide la información al usuario.
     do
     {
       Console.Write("¿Va a introducir los datos en millas? [S, N]: ");
       respuestaMillas = char.Parse(Console.ReadLine());
     } while (respuestaMillas != 'S' && respuestaMillas != 'N');

     Console.Write("Introduce la distancia: ");
     double distancia = double.Parse(Console.ReadLine());

     if (respuestaMillas == 'N')
     {
       Console.WriteLine("El coche ha consumido {0} litros.", consumo * distancia);
     }
     else if (respuestaMillas == 'S')
     {
       Console.WriteLine("El coche ha consumido {0:0.00} litros.", consumo * (distancia * 1.60934));
     }
   }
 }

/*
 * Programación 101 - C# Básico
 *
 * Refactorizando el anterior programa (ConsumoCocheAutovia.cs) crea un método
 * que realice la tarea y que tenga una sobrecarga que admita también el tipo
 * de datos int, aunque la salida deberá ser double. 
 *
 * Autor: Unai de la O.
 */

 using System;

 class ConsumoCocheAutovia2
 {
   // Lo más apto es guardar el consumo en litros por cada kilómetro.
   public static double consumo = 0.058;

   public static char respuestaMillas;

   public static bool enMillas;

   public static double CalculaConsumo(double km, bool enMillas)
   {
     if (enMillas == false)
     {
       return km * consumo;
     }
     return consumo * (km * 1.60934);
   }

   public static double CalculaConsumo(int km, bool enMillas)
   {
     double kmParsed = Convert.ToDouble(km);
     if (enMillas == false)
     {
       return kmParsed * consumo;
     }
     return consumo * (kmParsed * 1.60934);
   }

   public static void Main(string[] args)
   {
     // Pide la información al usuario.
     do
     {
       Console.Write("¿Va a introducir los datos en millas? [S, N]: ");
       respuestaMillas = char.Parse(Console.ReadLine());
     } while (respuestaMillas != 'S' && respuestaMillas != 'N');

     if (respuestaMillas == 'N')
     {
       enMillas = false;
     }
     else if (respuestaMillas == 'S')
     {
       enMillas = true;
     }

     Console.Write("Introduce la distancia: ");
     double distancia = double.Parse(Console.ReadLine());

     double resultadoFinal = CalculaConsumo(distancia, enMillas);

     Console.WriteLine("El coche ha consumido {0} litros.", resultadoFinal);
   }
 }

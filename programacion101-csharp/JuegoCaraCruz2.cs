/*
 * Programación 101 - C# Básico
 *
 * Extiende el programa anterior para que cuente las rachas en las cuales sale
 * el mismo resultado. Por ejemplo, si sale dos veces seguidas cara, anótalo.
 * Si luego sale cuatro veces seguidas cruz, sobreescribe el valor.
 * Te sorprenderás con el resultado.
 *
 * Autor: Unai de la O
 */

 using System;

 class JuegoCaraCruz2
 {
   public static void Main(string[] args)
   {
     int jugadas = 10000;
     int totalCaras = 0;
     int totalCruces= 0;
     int mayorRacha = 0;
     int rachaParcialCara = 0;
     int rachaParcialCruz = 0;
     int contadorCaras = 0;
     int contadorCruces = 0;

     Random numAleatorio = new Random();
     int resultadoMoneda;
     int eleccionUsuario;

     Console.Write("Elige cara (0) o cruz(1): ");
     eleccionUsuario = int.Parse(Console.ReadLine());

     if (eleccionUsuario == 0)
     {
       Console.WriteLine("Has elegido cara.");
     }
     else
     {
       Console.WriteLine("Has elegido cruz.");
     }

     Console.WriteLine("RESULTADOS");
     for (int i = 0; i < jugadas; i++)
     {
       resultadoMoneda = numAleatorio.Next(0, 2);

       if (resultadoMoneda == 0)
       {
         totalCaras++;
         contadorCaras++;
         contadorCruces = 0;
         if (contadorCaras > rachaParcialCara)
         {
           rachaParcialCara = contadorCaras;
         }
         if (rachaParcialCara > mayorRacha)
         {
           mayorRacha = rachaParcialCara;
         }
       }
       else
       {
         totalCruces++;
         contadorCruces++;
         contadorCaras = 0;
         if (contadorCruces > rachaParcialCruz)
         {
           rachaParcialCruz = contadorCruces;
         }
         if (rachaParcialCruz > mayorRacha)
         {
           mayorRacha = rachaParcialCruz;
         }
       }
     }
     Console.WriteLine("Jugadas: {0}\nCaras: {1}\nCruces: {2}\n",
                       jugadas, totalCaras, totalCruces);

     Console.WriteLine("Mayor Racha: {0}", mayorRacha);
     Console.WriteLine("Mayor Racha Caras: {0}", rachaParcialCara);
     Console.WriteLine("Mayor Racha Cruces: {0}", rachaParcialCruz);

     // Invitación al usuario para finalizar el programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }
 }

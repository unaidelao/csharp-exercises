/*
 * Programación 101 - C# Básico
 *
 * Crea un programa TOTALMENTE AUTOMATICO que juegue con una moneda a cara o
 * cruz. El programa jugará solo. Puedes generar un número aleatorio que cuando
 * sea 0 signifique que elige cara y cuando sea 1 que signifique que elige
 * cruz. Luego tira la moneda usando otro número aleatorio. Haz que el programa
 * juegue automáticamente 10000 jugadas y vete anotando en dos variables cuando
 * gana y cuando pierde. Después de las 10000 jugadas, imprime el numero de
 * tiradas ganadas y el número de tiradas perdidas y comprueba que ambos están
 * muy cerca de 5000 (50% de probabilidad).
 *
 * Autor: Unai de la O
 */
 
 using System;
 
 class JuegoCaraCruz
 {
   public static void Main(string[] args)
   {
     int jugadas = 10000;
     int totalGanadas = 0;
     int totalPerdidas= 0;
     
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
       
       if (resultadoMoneda == eleccionUsuario)
       {
         totalGanadas++;
       }
       else
       {
         totalPerdidas++;
       }
     }
     Console.WriteLine("Jugadas: {0}\nGanadas: {1}\nPerdidas: {2}\n",
                       jugadas, totalGanadas, totalPerdidas);
     
     // Invitación al usuario para finalizar el programa.
     Console.WriteLine("Pulsa una tecla para salir del programa...");
     Console.ReadKey();
   }
 }
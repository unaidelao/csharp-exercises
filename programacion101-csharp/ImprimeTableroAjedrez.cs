/*
 * Programación 101 - C# Básico
 *
 * Crea un array que sea como empieza un tablero de ajedrez. Para ello, en
 * lugar de almacenar números, nuestra array almacenará string. Los peones
 * serán P, Caballos C, Alfiles A, Reina R, Rey K.
 *
 * Luego, muestralo por pantalla. Las casillas en blanco pueden ser un espacio.
 *
 * Autor: Unai de la O.
 */

 using System;

 class ImprimeTableroAjedrez
 {
   public static void Main(string[] args)
   {
     // El tamaño del array será 8, porque es la medida de todo tablero.
     string[] tablero = new string[8];
     // Se inicializa el tablero.
     IniciaTablero(tablero);

     Console.WriteLine("TABLERO DE AJEDREZ");
     Console.Write("Pulsa una tecla para imprimir el tablero: ");
     Console.ReadKey();
     Console.WriteLine();

     // Llamada a función para imprimir el tablero.
     ImprimeTablero(tablero);

     // Invitación al usuario a finalizar el programa.
     Console.Write("\nPulse una tecla para finalizar el programa...");
     Console.ReadKey();
   }

   // Función que rellena una fila del tablero con peones.
   public static void RellenaPeones(string[] arrStr, int index)
   {
     arrStr[index] = "P P P P P P P P";
   }

   // Función que rellena una fila del tablero con figuras.
   public static void RellenaFiguras(string[] arrStr, int index)
   {
     arrStr[index] = "T C A R K A C T";
   }

   // Función que rellena una fila del tablero con casillas en blanco.
   public static void RellenaCasillasVacias(string[] arrStr, int index)
   {
     arrStr[index]     = "                ";
     arrStr[index + 1] = "                ";
     arrStr[index + 2] = "                ";
     arrStr[index + 3] = "                ";
   }

   // Función para inicializar el tablero.
   public static void IniciaTablero(string[] arrStr)
   {
     RellenaFiguras(arrStr, 0);
     RellenaPeones(arrStr, 1);
     RellenaCasillasVacias(arrStr, 2);
     RellenaPeones(arrStr, 6);
     RellenaFiguras(arrStr, 7);
   }

   // Función para imprimir el tablero por pantalla.
   public static void ImprimeTablero(string[] arrStr)
   {
     for (int i = 0; i < 8; i++)
     {
       Console.WriteLine(arrStr[i]);
     }
   }
 }

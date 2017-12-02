/*
 * Programación 101 - C# Básico
 *
 * Haz que el usuario introduzca diez números y almacénalos en una array.
 * Luego muestra por pantalla la suma, resta, multiplicación y división de
 * todos ellos.
 *
 * Autor: Unai de la O.
 *
 * NOTA DEL AUTOR: A este programa le falta incluir el manejo de excepciones,
 * como la "DivideByZeroException", así como controlar que el usuario sólo
 * pueda introducir el tipo de dato correcto.
 */

 using System;

 class ArrayConAritmetica
 {
    // Declaración de array con capacidad para 10 números.
    private static double[] arrayNums = new double[10];
    // Declaración de variables para alojar los operandos.
    private static double primerNumero;
    private static double segundoNumero;

    // Variable para alojar el tipo de operación aritmética a realizar.
    private static char signoOperacion;

    public static void Main(string[] args)
    {

      RellenaArray(arrayNums);

      ImprimeArray(arrayNums);

      EligeOperandos(arrayNums);

      EligeOperacion();

      RealizaOperacion(primerNumero, segundoNumero, signo: signoOperacion);

      // Invita al usuario a finalizar el programa.
      Console.WriteLine("Pulsa una tecla para finalizar el programa...");
      Console.ReadKey();
    }

    // Pide al usuario rellenar el array con números enteros.
    static void RellenaArray(double[] arr)
    {
      Console.WriteLine("Vamos a introducir 10 números enteros:");
      for (int i = 0; i < arr.Length; i++)
      {
        Console.Write("Introduce número en posición {0}: ", i);
        arr[i] = double.Parse(Console.ReadLine());
      }
    }

    // Muestra por pantalla el array.
    static void ImprimeArray(double[] arr)
    {
      Console.WriteLine("\nTe muestro el array para tu comodidad...\n");
      Console.WriteLine("POS\t [0]\t [1]\t [2]\t [3]\t [4]\t [5]" +
      "\t [6]\t [7]\t [8]\t [9]");
      foreach (double num in arr)
      {
        Console.Write("\t{0,3}", num);
      }
      Console.WriteLine();
    }

    // Elige los operandos.
    static void EligeOperandos(double[] arr)
    {
      Console.WriteLine("\nAhora, vas a elegir dos números del array " +
      "indicando sus posiciones:");
      Console.Write("Primer número: ");
      int indice1 = int.Parse(Console.ReadLine());
      primerNumero = arr[indice1];
      Console.Write("Segundo número: ");
      int indice2 = int.Parse(Console.ReadLine());
      segundoNumero = arr[indice2];
    }

    static void EligeOperacion()
    {
      Console.Write("Indica el tipo de operación aritmética tecleando " +
      "su símbolo(+, -, *, /): ");
      signoOperacion = char.Parse(Console.ReadLine());
    }
    // Realiza la operación aritmética
    static void RealizaOperacion(double num1, double num2, char signo)
    {
      switch (signo)
      {
        case '+':
          Console.WriteLine("El resultado es: {0} \n", num1 + num2);
          break;
        case '-':
          Console.WriteLine("El resultado es: {0} \n", num1 - num2);
          break;
        case '*':
          Console.WriteLine("El resultado es: {0} \n", num1 * num2);
          break;
        case '/':
          Console.WriteLine("El resultado es: {0} \n", num1 / num2);
          break;
        default:
          Console.WriteLine("Eres un troll de mierda, ¿no?\n");
          break;
      }
    }
}

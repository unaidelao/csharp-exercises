using System;

public class ArrayBidimensional
{
    public static void ImprimeArray(int[,] array)
    {
        int rowLength = array.GetLength(0);
        int colLength = array.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write("{0} ", array[i, j]);
            }
            Console.Write(Environment.NewLine + Environment.NewLine);
        }
        Console.ReadLine();
    }

    public static void Main(String[] args)
    {
        int[,] arrPrueba = new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
        ImprimeArray(arrPrueba);
        Console.ReadLine();
    }
}
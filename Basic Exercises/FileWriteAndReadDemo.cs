/*
 * Programa ejemplo de uso de streams: crear archivo, escribir, leer archivo y
 * recuperar la información contenida.
 */
 
 using System;
 using System.IO;
 
 class FileWriteAndReadDemo
 {
   public static void Main()
   {
     StreamWriter writer = new StreamWriter("test.txt");
     writer.WriteLine("hello world");
     writer.Close();
     
     StreamReader reader = new StreamReader("test.txt");
     while (reader.EndOfStream == false)
     {
       string line = reader.ReadLine();
       Console.WriteLine(line);
     }
     reader.Close();
   }
 }
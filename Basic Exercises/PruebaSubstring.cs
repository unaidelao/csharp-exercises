using System;

class PruebaSubstring
{
  public static void Main(string[] args)
  {
    string texto = "CROAR#AB_CD_22#50";
    
    string evento = texto.Substring(0, 5);
    
    if (texto.Substring(0, 5) == "CREAR")
    {
      Console.WriteLine("Coincide.");
    }
    else
    {
      Console.WriteLine("Algo falla...");
    }
  }
}
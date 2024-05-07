using System;

class Desafio
{
  static void Main()
  {
    int limit = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < limit; i++)
    {
      string[] line = Console.ReadLine().Split(" ");
      double X = double.Parse(line[0]);
      double Y = double.Parse(line[1]);
      if (Y != 0)
      {
        double res = X / Y;
        System.Console.WriteLine($"{res:0.0}");
      }
      else
      {
        System.Console.WriteLine("divisao impossivel");
      }
    }
  }
}
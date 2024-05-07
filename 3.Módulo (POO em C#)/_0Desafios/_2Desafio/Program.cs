using System;

namespace Start
{
  class Program
  {
    static void Main(string[] args)
    {
      double A, B, C;
      A = double.Parse(Console.ReadLine()); // peso 2
      B = double.Parse(Console.ReadLine()); // peso 3
      C = double.Parse(Console.ReadLine()); // peso 5

      Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5)));
    }
  }
}
using System;

class Program
{
  static void Main(string[] args)
  {
    int a, b;
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    int PROD = a * b;
    Console.WriteLine($"PROD = {PROD}");
    Console.ReadLine();
  }
}
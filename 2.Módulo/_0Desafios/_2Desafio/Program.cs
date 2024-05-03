using System;

class MinhaClasse
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    var hours = N / 3600;
    var minutes = (N / 60) % 60;
    var seconds = N % 60;
    Console.WriteLine($"{hours}:{minutes}:{seconds}");
  }
}
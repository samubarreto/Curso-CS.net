using System;

class Fibonacci
{
  public static int Fib(int n)
  {
    if (n <= 1)
      return n;
    else
      return Fib(n - 1) + Fib(n - 2);
  }

  public static void Main()
  {
    Console.WriteLine("Digite o número de termos da sequência de Fibonacci que você deseja gerar:");
    int count = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Sequência de Fibonacci:");
    for (int i = 0; i < count; i++)
    {
      Console.Write(Fib(i) + " ");
    }
  }
}

using System;

class TESTE
{
  static void Main(string[] args)
  {
    int n;
    int maior = 0;
    int posicao = 0;
    for (int i = 1; i <= 100; i++)
    {
      n = Convert.ToInt32(Console.ReadLine());
      if (n > maior)
      {
        maior = n;
        posicao = i;
      }
    }
    Console.WriteLine(maior);
    Console.WriteLine(posicao);
  }
}
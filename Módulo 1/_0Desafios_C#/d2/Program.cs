﻿//Abaixo segue um exemplo de código que você pode ou não utilizar
using System;

class minhaClasse
{

  static void Main(string[] args)
  {

    int quantidadeNumeros = int.Parse(Console.ReadLine());
    string[] numeros = Console.ReadLine().Split(' ');

    int multiplo2 = 0;
    int multiplo3 = 0;
    int multiplo4 = 0;
    int multiplo5 = 0;

    //TODO: Complete os espaços em branco com uma possível solução para o desafio
    for (int c = 0; c < quantidadeNumeros; c++)
    {
      if (int.Parse(numeros[c]) % 2 == 0)
      {
        multiplo2++;
      }
      if (int.Parse(numeros[c]) % 3 == 0)
      {
        multiplo3++;
      }
      if (int.Parse(numeros[c]) % 4 == 0)
      {
        multiplo4++;
      }
      if (int.Parse(numeros[c]) % 5 == 0)
      {
        multiplo5++;
      }
    }

    Console.WriteLine("{0} Multiplo(s) de 2", multiplo2);
    Console.WriteLine("{0} Multiplo(s) de 3", multiplo3);
    Console.WriteLine("{0} Multiplo(s) de 4", multiplo4);
    Console.WriteLine("{0} Multiplo(s) de 5", multiplo5);
  }
}
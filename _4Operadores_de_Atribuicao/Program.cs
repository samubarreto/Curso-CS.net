// int a = 10;
// int b = 20;

// int c = a + b;
// c += 5;
// c -= 5;
// c /= 5;
// c *= 5;

// Console.WriteLine(c);

// int d = int.Parse("5");
// int e = Convert.ToInt32(null);
// int f = 90;
// string g = f.ToString();

// Console.WriteLine($"{d}, {e}, {g}");

// // Isso não da erro pois int está contido em double, se tentasse fazer o contrário daria errado:
// int h = 5;
// double i = h;

// Console.WriteLine(i);

// long j = long.MaxValue;
// Console.WriteLine(j);

// string k = "1-5";
// // int l = 0;

// int.TryParse(k, out int l); // tenta converter

// Console.WriteLine(l);

// Condicionais

// int quantidadeEmEstoque = 10;
// int quantidadeCompra = -4;
// bool possibilidadeDeVenda = quantidadeEmEstoque >= quantidadeCompra && quantidadeCompra > 0;

// Console.WriteLine($"Estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar venda? {possibilidadeDeVenda}");

// if (possibilidadeDeVenda)
// {
//   if (quantidadeCompra <= 0)
//   {
//     Console.WriteLine("Venda inválida.");
//   }
//   else
//   {
//     Console.WriteLine("Venda realizada.");
//   }
// }
// else
// {
//   Console.WriteLine("Desculpe, não temos a quantidade em estoque.");
// }

// Console.WriteLine("Digite uma letra: ");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//   case "a":
//   case "e":
//   case "i":
//   case "o":
//   case "u":
//     Console.WriteLine($"{letra} é Vogal");
//     break;
//   default:
//     Console.WriteLine($"{letra} não é Vogal");
//     break;
// }

// bool maiorDeIdade = false;
// bool possuiAutorizacao = false;

// if (maiorDeIdade || possuiAutorizacao)
// {
//   Console.WriteLine("blz");
// }
// else
// {
//   Console.WriteLine("not blz");
// }

// bool presencaMinima = true;
// double media = 7.7;

// if (presencaMinima && media >= 7)
// {
//   Console.WriteLine("boa");
// }
// else
// {
//   Console.WriteLine("not boa");
// }

// bool chuva = false;
// bool tarde = false;

// if (!chuva && !tarde)
// {
//   Console.WriteLine("bike");
// }
// else
// {
//   Console.WriteLine("not bike");
// }
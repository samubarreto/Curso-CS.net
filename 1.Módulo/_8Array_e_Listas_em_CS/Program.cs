int c;
List<string> listaString = new List<string>(); // não precisa passar capacidade

listaString.Add("BRL");
listaString.Add("EUR");
listaString.Add("JPN");
listaString.Add("USD");

Console.WriteLine("\n-Percorrendo lista com for");
for (c = 0; c < listaString.Count; c++)
{
  Console.WriteLine($"{c + 1}º = {listaString[c]}");
}

Console.WriteLine("\n-Percorrendo lista com foreach");
c = 1;
foreach (string elemento in listaString)
{
  Console.WriteLine($"{c}º = {elemento}");
  c++;
}

Console.WriteLine("\nFacilidades da lista:");
Console.WriteLine($"Quantidade de itens na lista: {listaString.Count}");
Console.WriteLine($"Capacidade de itens na lista: {listaString.Capacity}");

listaString.Add("GBP"); Console.WriteLine("\nGBP adicionado.");
Console.WriteLine($"Quantidade de itens na lista: {listaString.Count}");
Console.WriteLine($"Capacidade de itens na lista: {listaString.Capacity}");

listaString.Remove("USD"); Console.WriteLine("\nUSD removido.");
Console.WriteLine($"Quantidade de itens na lista: {listaString.Count}");
Console.WriteLine($"Capacidade de itens na lista: {listaString.Capacity}");

// int[] arrayInteiros = new int[3];
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];

// arrayInteiros[0] = 25;
// arrayInteiros[1] = 54;
// arrayInteiros[2] = 89;

// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// Console.WriteLine("\n-Percorrendo array dobrado com foreach");
// int c = 1;
// foreach (int valor in arrayInteirosDobrado)
// {
//   Console.WriteLine($"{c}º = {valor}");
//   c++;
// }

// Console.WriteLine("\n-Percorrendo array com foreach");
// c = 1;
// foreach (int valor in arrayInteiros)
// {
//   Console.WriteLine($"{c}º = {valor}");
//   c++;
// }

// Console.WriteLine("\n-Percorrendo array com for");
// for (c = 0; c < arrayInteiros.Length; c++)
// {
//   Console.WriteLine($"{c}º = {arrayInteiros[c]}");
// }

// Resize
// Console.Write(arrayInteiros.Length + " -> ");
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
// Console.Write(arrayInteiros.Length);


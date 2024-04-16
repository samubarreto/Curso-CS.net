using _4Tuplas_Operador_Ternario_Desconstrucao_obj.Models;

int num = 201;
bool ehPar = false;

ehPar = num % 2 == 0;
Console.WriteLine($"O número {num} é " + (ehPar ? "par" : "ímpar"));

// if (num % 2 == 0)
// {
//   Console.WriteLine("Par");
// }
// else
// {
//   Console.WriteLine("Ímpar");
// }

// Pessoa p1 = new Pessoa("Samuel", "Pereira", 19);

// (string? nome, string? sobrenome, int? idade) = p1;

// Console.WriteLine($"{nome} {sobrenome}, {idade}");

// // tupla

// (int, string, string, decimal) tupla = (0, "Samuel", "Pereira", 1.75M); // uma única variável consegue representar 3 valores de tipos diferentes
// Console.WriteLine($"\nID: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");

// // tupla dnv

// ValueTuple<int, string, string, decimal> outroExemplo = (1, "Samuel", "Pereira", 1.75M);
// Console.WriteLine($"\nID: {outroExemplo.Item1}");
// Console.WriteLine($"Nome: {outroExemplo.Item2}");
// Console.WriteLine($"Sobrenome: {outroExemplo.Item3}");
// Console.WriteLine($"Altura: {outroExemplo.Item4}");

// // tupla dnv

// var maisUmExemplo = Tuple.Create(2, "Samuel", "Pereira", 1.75M);
// Console.WriteLine($"\nID: {maisUmExemplo.Item1}");
// Console.WriteLine($"Nome: {maisUmExemplo.Item2}");
// Console.WriteLine($"Sobrenome: {maisUmExemplo.Item3}");
// Console.WriteLine($"Altura: {maisUmExemplo.Item4}");

// LeituraArquivo reader = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = reader.LerArquivo("Files//teste.txt");
// if (sucesso)
// {
//   foreach (string linha in linhasArquivo)
//   {
//     Console.WriteLine(linha);
//   }
// }
// else
// {
//   Console.WriteLine("Não foi possível ler o arquivo.");
// }
using Newtonsoft.Json;
using _6Tipos_especiais_cs.Models;

#pragma warning disable CS8600
#pragma warning disable CS8602
#pragma warning disable CS8604

// método de extensão
// adicionar tipos sem criar um novo, só extendendo de um outro já existente

int num = 201;
Console.WriteLine(num.EhPar() ? "par" : "ímpar");

// ---

// classes genéricas
// encapsulam operações que não são específicas de um determinado tipo de dado
// podem receber qualquer tipo de valor como argumento e farão sempre o eperado independente do tipo recebido

// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();
// arrayString.AdicionarElementoArray("string teste");
// Console.WriteLine(arrayString[0]);

// ---

// tipo dinâmico permite alterar o tipo de valor armazenado na variável dinamicamente

// dynamic variavelDinamica = 4;
// Console.WriteLine($"Tipo atual: {variavelDinamica.GetType()} | Valor atual: {variavelDinamica}");
// variavelDinamica = "string";
// Console.WriteLine($"Tipo atual: {variavelDinamica.GetType()} | Valor atual: {variavelDinamica}");
// variavelDinamica = 4.554;
// Console.WriteLine($"Tipo atual: {variavelDinamica.GetType()} | Valor atual: {variavelDinamica}");
// variavelDinamica = true;
// Console.WriteLine($"Tipo atual: {variavelDinamica.GetType()} | Valor atual: {variavelDinamica}");

// tipo anônimo tem apenas get, não pode ser setado, alterado. Comummente usado para armazenar retorno de uma função

// try
// {
//   string? conteudoArquivo = File.ReadAllText("Files//vendas.json");

//   List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
//   var listaAnonima = listaVenda.Select(x => new { x.Produto, x.Preco });

//   foreach (var venda in listaAnonima)
//   {
//     Console.WriteLine($"Produto: {venda.Produto} | Preço: {venda.Preco:C}");
//   }
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Não foi possível consumir o arquivo de vendas: {ex.Message}");
// }

// var tipoAnonimo = new { Nome = "Samuel", Sobrenome = "Pereira", Altura = 1.80 }; 

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);

//---

// try
// {
//   string? conteudoArquivo = File.ReadAllText("Files//vendas.json");

//   List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
//   foreach (Venda venda in listaVenda)
//   {
//     Console.WriteLine($"ID: {venda.IdVenda} | Produto: {venda.Produto,-20} | Preço: {venda.Preco,-8:C} | Data da venda: {(venda.DataVenda != null ? venda.DataVenda.Value.ToString("dd/MM/yyyy HH:mm") : "Data não disponível")} | Desconto: {(venda.Desconto.HasValue ? $"{venda.Desconto:C}" : "Sem desconto")}");
//   }
// }
// catch (Exception ex)
// {
//   Console.WriteLine($"Não foi possível consumir o arquivo de vendas: {ex.Message}");
// }
// -------
// bool? desejaReceberEmail = null;

// if (desejaReceberEmail != null && desejaReceberEmail.Value)
// {
//   Console.WriteLine("Boa");
// }
// else
// {
//   Console.WriteLine("Não");
// }
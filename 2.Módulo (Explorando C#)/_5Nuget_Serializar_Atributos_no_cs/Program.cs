// https://www.nuget.org/packages
// dotnet add package Newtonsoft.Json
using Newtonsoft.Json;
using Models;

try
{
  string conteudoArquivo = File.ReadAllText("Files//vendas.json");

  List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
  foreach (Venda venda in listaVenda)
  {
    Console.WriteLine($"ID: {venda.IdVenda} | Produto: {venda.Produto} | Preço: {venda.Preco} | Data da venda: {venda.DataVenda.ToString("dd/MM/yyy HH:mm")}");
  }
}
catch (Exception ex)
{
  Console.WriteLine($"Não foi possível consumir o arquivo de vendas: {ex.Message}");
}


// DateTime dataAtual = DateTime.Now;

// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(0, "3DS", 600.00M, dataAtual);
// Venda v2 = new Venda(1, "Nintendo Switch Lite", 1500.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);

// // usando a lib newtonsoft json
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
// File.WriteAllText("Files//vendas.json", serializado);

// Console.WriteLine(serializado);
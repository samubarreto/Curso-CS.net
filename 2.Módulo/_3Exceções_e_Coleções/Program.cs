using System.Globalization;

// lendo todas linhas de outro arquivo
string[] linhas = File.ReadAllLines("Files//arquivoLeitura.txt");

foreach (string linha in linhas)
{
  Console.WriteLine(linha);
}

// passando nome do arquivo errado e tratando com try catch
try
{
  string[] linhas2 = File.ReadAllLines("Files//arquivoLeitura.txt");

  foreach (string linha in linhas2)
  {
    Console.WriteLine(linha);
  }
}
catch (FileNotFoundException ex)
{
  Console.WriteLine($"Arquivo não encontrado: {ex.Message}");
}
catch (DirectoryNotFoundException ex)
{
  Console.WriteLine($"Caminho de arquivo não encontrado: {ex.Message}");
}
catch (Exception ex)
{
  Console.WriteLine($"Erro genérico: {ex.Message}");
}

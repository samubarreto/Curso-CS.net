// using System.Globalization;
// using _3Exceções_e_Coleções.Models;

Dictionary<string, string> Estados = new Dictionary<string, string>();

Estados.Add("São Paulo", "SP");
Estados.Add("Rio de Janeiro", "RJ");
Estados.Add("Minhas Gerais", "MG");
Estados.Add("Espírito Santo", "ES");
Estados.Add("Piauí", "PI");
Estados.Add("Alagoas", "AL");
Estados.Add("Bahia", "BA");

foreach (var item in Estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("Removendo BH:\n");
Estados.Remove("Bahia");

foreach (var item in Estados)
{
  Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

if (Estados.ContainsKey("Piauí"))
{
  Console.WriteLine("Tem Piauí");
}
else
{
  Console.WriteLine("Não tem Piauí");
}

// PILHA STACK LIFO last in first out

Stack<int> pilha = new Stack<int>();
pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

pilha.Pop(); // remove e retorna o item no topo da pilha (8)

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

pilha.Push(20); // insere o 20 no topo da pilha

foreach (int item in pilha)
{
  Console.WriteLine(item);
}

// FILA QUEUE FIFO first in first out

Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
  Console.WriteLine(item);
}

fila.Dequeue(); // sempre remove o pimeiro elemento e retorna ele tb (2)

foreach (int item in fila)
{
  Console.WriteLine(item);
}

new ExemploException().Metodo1();

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
finally
{
  Console.WriteLine("\nBloco finally sempre será executado, independete de ter tido exception ou não.");
}

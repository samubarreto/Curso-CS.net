// namespace -> caminho lógico que serve para identificar/especificar classes diferentes com nomes iguais
// using _3Sintaxe_e_Indentação.Models;

// ---

// string apresentacao = "Olá, seja bem vindo!";

// int quantidade = 1;
// Console.WriteLine(quantidade);
// quantidade = 10;

// double altura = 1.70;

// decimal preco = 30.80M;

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine(quantidade);
// Console.WriteLine(altura.ToString("0.00"));
// Console.WriteLine(preco);
// Console.WriteLine(condicao);

// ---

// Pessoa pessoa1 = new();

// pessoa1.Nome = "Samu";
// pessoa1.Idade = 19;
// pessoa1.Apresentar();

// ---

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);
Console.WriteLine(dataAtual.AddYears(79));
Console.WriteLine(dataAtual.AddYears(79).ToString("dd/mm/yyyy"));
Console.WriteLine(dataAtual.AddYears(79).ToString("dd/mm/yyyy HH:mm"));
Console.WriteLine(dataAtual.AddYears(79).ToString("dd/mm/yyyy hh:mm"));
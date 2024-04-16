using _2Manipulando_valores_cs.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMontetario = 8367457456752.40M;
Console.WriteLine($"{valorMontetario:C}");
Console.WriteLine(valorMontetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
Console.WriteLine(valorMontetario.ToString("C8"));

double porcentagem = .3321;
Console.WriteLine(porcentagem.ToString("P"));

int num = 123456;
Console.WriteLine(num.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data);
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // importante usar bem maiúsculos e minúsculos, ver a documentação quando necessário
Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm")); // importante usar bem maiúsculos e minúsculos, ver a documentação quando necessário
Console.WriteLine(data.ToShortDateString());
Console.WriteLine(data.ToShortTimeString());

DateTime dataConvertida = DateTime.Parse("09/12/1999 12:23"); // converte string para tipo datetime válido, se der erro retorna exception...
Console.WriteLine(dataConvertida);

// DateTime dataConvertidaTratada = DateTime.TryParseExact("2002-12-8 18:00", "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2); // n retorna exception em caso de erro

// Pessoa aluno1 = new Pessoa(nome: "Rafael", sobrenome: "Souto", idade: 18);
// Pessoa aluno2 = new Pessoa(nome: "Ana", sobrenome: "Silva", idade: 25);
// Pessoa aluno3 = new Pessoa(nome: "João", sobrenome: "Martins", idade: 30);

// Curso cursoDeDOTNET = new();
// cursoDeDOTNET.NomeCurso = "Curso DOTNET"
// cursoDeDOTNET.Alunos = new List<Pessoa>();

// cursoDeDOTNET.AdicionarAluno(aluno1);
// cursoDeDOTNET.AdicionarAluno(aluno2);
// cursoDeDOTNET.AdicionarAluno(aluno3);
// cursoDeDOTNET.ListarAlunos();
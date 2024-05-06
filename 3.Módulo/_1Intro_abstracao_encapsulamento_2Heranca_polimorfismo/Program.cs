using _1Intro_abstracao_encapsulamento_2Heranca_polimorfismo.Models;
using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// // encapsulamento
// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(899999);
// c1.ExibirSaldo();
// c1.Sacar(999);
// c1.ExibirSaldo();

// abstração, herança e polimorfismo
Pessoa pessoa1 = new()
{
  Nome = "Samu",
  Idade = 20
};
pessoa1.Apresentar();

Aluno aluno1 = new()
{
  Nome = "Samu",
  Idade = 20,
  Email = "samu@teste.com",
  Nota = 10
};
aluno1.Apresentar();

Professor professor1 = new()
{
  Nome = "Samu",
  Idade = 20,
  Salario = 5000
};
professor1.Apresentar();

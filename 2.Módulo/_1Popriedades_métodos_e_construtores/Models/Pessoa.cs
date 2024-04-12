using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Popriedades_métodos_e_construtores.Models
{
	public class Pessoa
	{
		public Pessoa(string nome, string sobrenome, int idade)
		{
			Nome = nome;
			Sobrenome = sobrenome;
			Idade = idade;
		}
		private string? _Nome; // privates não são acessíveis no program.cs

		public string? Nome
		{
			get => _Nome;

			// get => _nome.ToUpper();

			set
			{
				if (value == "")
				{
					throw new ArgumentException("O nome não pode ser vazio");
				}
				_Nome = value;
			}

			// set => if (value == "") throw new ArgumentException("O nome não pode ser vazio"); _Nome = value;
		}

		public string? Sobrenome { get; set; }

		public string? NomeCompleto => $"{Nome} {Sobrenome}".ToUpper(); // só get

		private int? _Idade; // privates não são acessíveis no program.cs
		public int? Idade
		{
			get => _Idade;

			set
			{
				if (value < 0)
				{
					throw new ArgumentException("A idade não pode ser menor que zero.");
				}
				_Idade = value;
			}
		}

		public void Apresentar()
		{
			Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
		}
	}
}
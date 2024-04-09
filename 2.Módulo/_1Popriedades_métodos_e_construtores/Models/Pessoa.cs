using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Popriedades_métodos_e_construtores.Models
{
	public class Pessoa
	{
		private string? _Nome;
		private int? _Idade;

		public string? Nome
		{
			get
			{
				return _Nome.ToUpper();
			}

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

		public int? Idade
		{
			get => _Idade;

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
			Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
		}
	}
}
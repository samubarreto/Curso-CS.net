using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Intro_abstracao_encapsulamento_2Heranca_polimorfismo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"\n>PROFESSOR: meu nome é {Nome}, tenho {Idade} anos, e meu salário é de {Salario:C}.");

        }
    }
}
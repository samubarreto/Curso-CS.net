using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Intro_abstracao_encapsulamento_2Heranca_polimorfismo.Models
{
    public class Aluno : Pessoa
    {
        public string Email { get; set; }
        public double Nota { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"\n>ALUNO: meu nome é {Nome}, tenho {Idade} anos, meu email é {Email} e minha nota é {Nota}.");
        }
    }
}
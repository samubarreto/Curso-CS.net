using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Intro_abstracao_encapsulamento_2Heranca_polimorfismo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"\n>PESSOA: meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}
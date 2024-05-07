using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1Intro_abstracao_encapsulamento_2Heranca_polimorfismo.Models
{
    // abstração
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = NumeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        // encapsulamento
        private decimal saldo;
        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine("Saque realizado.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para o saque.");
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é de {saldo:C}");
        }
    }
}
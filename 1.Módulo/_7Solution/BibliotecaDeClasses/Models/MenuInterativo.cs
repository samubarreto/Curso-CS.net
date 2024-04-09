using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaDeClasses.Models
{
    public class MenuInterativo
    {
        public static void Inicio()
        {
            Console.WriteLine("Digite uma opção:");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Buscar cliente");
            Console.WriteLine("3 - Apagar cliente");
            Console.WriteLine("4 - Encerrar");
            CheckOption(Console.ReadLine());
        }
        public static void CheckOption(string choosedOption)
        {
            switch (choosedOption)
            {
                case "1":
                    Console.WriteLine("Cadastro de Cliente.");
                    break;
                case "2":
                    Console.WriteLine("Busca de Cliente.");
                    break;
                case "3":
                    Console.WriteLine("Apagar Cliente.");
                    break;
                case "4":
                    Console.WriteLine("Encerrar.");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção Inválida.");
                    break;
            }
            Inicio();
        }
    }
}
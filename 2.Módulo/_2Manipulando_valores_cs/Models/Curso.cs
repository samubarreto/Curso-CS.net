using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2Manipulando_valores_cs.Models
{
    public class Curso
    {
        public string NomeCurso { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public Curso()
        {
            Alunos = new List<Pessoa>();
        }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos!.Add(aluno);
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos!.Remove(aluno);
        }

        public int GetQuantidadeAlunos()
        {
            return Alunos!.Count;
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do {NomeCurso}");

            for (int index = 0; index <= Alunos.Count; index++)
            {
                Console.WriteLine($"{index}º: {Alunos[index + 1].NomeCompleto}");
            }
        }
    }
}
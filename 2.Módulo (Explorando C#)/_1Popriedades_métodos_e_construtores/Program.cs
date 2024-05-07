using _1Popriedades_métodos_e_construtores.Models;

Pessoa aluno1 = new Pessoa(nome: "Rafael", sobrenome: "Souto", idade: 18);
Pessoa aluno2 = new Pessoa(nome: "Ana", sobrenome: "Silva", idade: 25);
Pessoa aluno3 = new Pessoa(nome: "João", sobrenome: "Martins", idade: 30);

Curso cursoDeDOTNET = new();
cursoDeDOTNET.NomeCurso = "Curso DOTNET";
cursoDeDOTNET.Alunos = new List<Pessoa>();

cursoDeDOTNET.AdicionarAluno(aluno1);
cursoDeDOTNET.AdicionarAluno(aluno2);
cursoDeDOTNET.AdicionarAluno(aluno3);
cursoDeDOTNET.ListarAlunos();
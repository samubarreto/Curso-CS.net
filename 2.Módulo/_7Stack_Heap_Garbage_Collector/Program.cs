using _7Stack_Heap_Garbage_Collector.Models;

Pessoa p1 = new(nome: "Samuel", sobrenome: "Pereira", idade: 20);
Pessoa p2 = new(nome: "Google", sobrenome: "Junior", idade: 3);

// isso aq da errado pois p3 aponta para o mesmo enderênço de memória de p2, então quaisquer alterações nos valores de p3 serão refletidas para p2
Pessoa p3 = p2;
p3.Nome = "Bubi";

Console.WriteLine($"Nome p1: {p1.NomeCompleto}");
Console.WriteLine($"Nome p2: {p2.NomeCompleto}");
Console.WriteLine($"Nome p3: {p3.NomeCompleto}");
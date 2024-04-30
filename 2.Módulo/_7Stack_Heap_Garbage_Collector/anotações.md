* Alocação de memória

  * Dependendo do tipo da variável ela é armazenada em stack ou em heap:
    * stack: pilha, vai pra memória ram, int, decimal, boolean, string, float, double... memória estática
    * heap: objetos vão pro heap, a referência deles fica na stack, memória dinâmica pois armazena objetos, que são mais complexos
  * Limpeza de Memória com Garbage Collector:
    * first in last out
    * Todo objeto do heap sem referência de variável na stack é morto pelo garbage collector
  * Tipo de Valor:
    * Uma variável de um tipo de valor contém uma instância do tipo, tudo pra stack. Heap não é usado
    * ```csharp
      void Metodo()
      {
          int a = 5;
          int b = a; // b vai ser = 5, simples assim
      }
      ```
  * Tipo de Referência:
    * Uma variável de um tipo de refferência contém uma referência a uma instância do tipo, aponta pra um determinado endereço do heap
    * ```csharp
      void Metodo()
      {
          Pessoa p1 = new Pessoa("Samuel", "Pereira");
          Pessoa p2 = p1; // apontam pro mesmo endereço no heap, não duplica p1 e chama de p2.. então a linha abaixo troca o valor de Nome de p1 e p2, pois ambos apontam para a mesma referência da instância Pessoa
          p2.Nome = "Google';
      }
      ```

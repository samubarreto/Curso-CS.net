* Array
  * Estrutura de dados que **armazena valores do mesmo tipo, com um tamanho fixo.**
    * int[] arrayExemplo1 = new int[4]; -- 1 array de inteiros com 4 posições declaradas, sem valores alocados
    * int[] arrayExemplo1 = new int[] { 42, 75, 74, 61}; -- 1 array de inteiros com 4 posições declaradas e com valores alocados, quando alocamos valores o tamanho do array pode ser omitido
    * string[] arrayExemplo2 = { "Jan", "Fev" };
* Índice
  * int arrayExemplo3 = new int[] { 5, 10, 15, 20, 25 };
  * arrayExemplo3[2] = 15; -- true
* Sintaxe foreach:
* ```csharp
  Console.WriteLine("-Percorrendo array com foreach");
  int cont = 1;
  foreach (int valor in arrayInteiros)
  {
    Console.WriteLine($"{cont}º = {valor}");
    cont++;
  }
  ```
* Redimensionar array
  * Array.Resize(ref nomeDoArray, nomeDoArray.Length * 2);
    * Pega o endereço de memória do array e aumenta seu tamanho para o dobro do tamanho atual.
* Listas
  * Array "melhorado", também é capaz de armazenar coleções de objeto de mesmo tipo, mas com menos complexidades do Array, sem necessidade de passar a capacidade da lista, ela cresce conforme são adicionados elementos nela;
  * Facilidades para adicionar, remover e fazer consultas.

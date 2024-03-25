# Compilador .NET e seu funcionamento

* Sempre que modificar o código será necessário compilar, recompilar, buildar, rebuildar, dar build, dar rebuild...
* Linguagem de alto nível:

  * Linguagem que escrevemos e entendemos nosso código
  * `console.writeline("Hello World!")`
* Linguagem de baixo nível:

  * Linguagem que a máquina entende, 1 e 0.
* Compilador pega o código de alto nível e "converte, traduz" pra uma linguagem de baixo nível

  * Compilador do C# ->
    * arquivo.cs
    * C# compiler
    * IL (código de linguagem intermediária), arquivo.exe e arquivo.dll
    * JIT compiler durante a execução do programa
    * Código nativo
* Transpilador: Traduz alto nível para outra de alto nível, ex: TS para JS
* Linguagens compiladas: C#, Java, Go, Rust..
* Linguagem interpretada: Javascript, PHP, Python, Ruby..

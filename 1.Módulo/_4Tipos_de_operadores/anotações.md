Ctrl + º abre uma nova guia

* * int.Parse("5") converte o  5 de str pra int
    * se trocar o int pra decimal, double, float... e botar o .Parse("valorEmString"), será convertido
  * Da pra fazer parecido com Convert.ToInt32... e outros tipos.
* Principal diferença entre Parse e Convert:
  * O tratamento de valores nulos, Convert.ToInt32(null) converte null pra 0, enquanto que o int.Parse(null) da uma exception;
* Conversão para string:
  * string converter = variavelQualquer.ToString();
* Casting implícito:
  * int h=5;
  * double i=h;
* Isso não da erro pois int está contido em double, se tentasse fazer o contrário daria errado:
  * int h=5;
  * double i=h;
* .MaxValue é útil
* Ordem dos operadores é igual a ordem das operações da matemática.
* Conversão Segura:
  * string k = "1-5";
  * int l = 0;
  * int.TryParse(k, out l);
* Operador condicional:
  * if (condição) {ação}
  * else if (condição) {ação}
  * else {ação}
    * suave dms
* Input é feito com Console.Readline();
* Operadores lógicos:
  * || or
  * && and
  * ! not

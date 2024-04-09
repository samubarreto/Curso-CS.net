* Propriedades
  * É um membro que oferece um mecanismo flexível para ler, gravar ou calcular o valor de um campo particular.
  * props nome e idade abaixo
    * Pessoa
      * Nome: string
      * Idade: int
        * apresentar()
  * ```csharp
    private string _Nome;
            public string? Nome
            {
                get
                {
                    return _Nome.ToUpper();
                };
                set
                {
                    if (value == "")
                    {
                        throw new ArgumentException("O nome não pode ser vazio");
                    }
                    _Nome = value;
                };
            }
    ```

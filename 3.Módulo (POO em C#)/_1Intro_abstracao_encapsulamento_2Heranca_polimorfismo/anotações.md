* POO é um paradigma de programação, uma forma de se programar, um modelo de técnicas
* Outros paradigmas: estruturada, imperativa, procedural, orientada a eventos, lógica.
* POO:
  * Abstração: abstrair um objeto real para o contexto do código, considerando atributos relevantes para o contexto de uso. Trabalhar na **simplicidade**
  * Encapsulamento: Protege uma classe e define limites para alteração de propriedades por meio dos métodos padrão get e set e de métodos privados/públicos. Serve para ocultar comportamentos e expor somento o necessário
  * Herança: Permite a reutilização de atributos e métodos de uma classe em outra. Serve para agrupar objetos do mesmo tipo, mas com características diferentes. Só é possível herdar de uma classe
  * Polimorfismo: Sobrescrever métodos usando virtual no pai e override no filho
* Classe: Representação de um objeto real em	 código, um esqueleto de um objeto
* Objeto: Personificação, implementação da classe, faz uso dela

Resumo longo:

Abstração: Abstrair objetos reais em classes no código atribuindo a elas apenas os atributos relevantes para o contexto que será usado, exemplo: classe carro terá modelo, ano, combustível atual.. pois são úteis pro contexto. Um carro real teria também "modelo dos bancos", mas supondo que essa informação não seria útil pro contexto da aplicação ela não será usada, então não deve existir na classe Carro, isso é abstração.

Herança: Capacidade de usar atributos e métodos de uma classe pai em uma outra filha e adicionar especificidades da filha sem implicar no pai, por exemplo: Motorista e Repositor são classes que poderiam herdar da classe Funcionário, pois ambos são funcionários, ambos terão "Nome, Salário, Função, Data de admissão...", mas terão algumas pequenas diferenças que podem ser adicionadas individualmente sem atrapalhar nas outras classes ou na classe pai.

Polimorfismo: Capacidade de sobrescrever Métodos da classe pai em cada classe filho, exemplo: ao usar o método Apresentar para um Aluno, que herda de Pessoa ele diz: "Meu nome é Samu, minha nota é 10". Já ao usar o método Apresentar para um Professor, que também herda de Pessoa ele diz: "Meu nome é Samu e meu salário é R$9.000,00".

Encapsulamento: Capacidade de proteger atributos declarando-os como privados, para que possam ser alterados apenas pela própria classe, por exemplo o atributo privado "SaldoConta", de uma conta bancária, não pode ser diretamente setado, alterado com: conta1.SaldoConta = 99999. Por ser privado ele só poderá ser alterado por meio de um método público devidamente tratado como "Debitar" e "Sacar", dessa forma é possível adicionar camadas de verificação antes de fazer uma movimentação financeira, como por exemplo: Só é possível realizar um saque caso o ValorSaque seja <= SaldoConta, caso isso seja verdadeiro a movimentação é liberada. Dessa forma o SaldoConta estará sempre protegido.

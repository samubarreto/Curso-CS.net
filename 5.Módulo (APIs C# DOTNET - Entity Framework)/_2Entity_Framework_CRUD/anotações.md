* EF, ou Entity Framework é um ORM (Object Relational Mapping), que serve para facilitar a integração com bancos de dados, mapeando tabelas e gerando comandos SQL automaticamente.
* Camadas de uma aplicação:
  * UI
  * Camada de negócios [Classes, Controllers, Serviços]
  * Camada de dados [Entity Framework]
  * Banco de Dados
* CRUD -> Create, Read, Update, Delete

![1715624115287](image/anotações/1715624115287.png)

* dotnet tool install --global dotnet-ef
* conexão com o banco de dados fica em appSettings.json
* Migration: transformar classe em tabela

dotnet-ef migrations add CriacaoTabelaContato

dotnet-ef database update

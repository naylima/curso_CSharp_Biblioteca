# Projeto Biblioteca

## Descrição
O Projeto Biblioteca foi desenvolvido com o objetivo de modelar o sistema básico de uma biblioteca, onde é possível gerenciar empréstimos, livros e usuários (pessoas).

## Estrutura

### 1. Classe `Livro`
- **Atributos**:
  - `Nome`: Título do livro.
  - `Autor`: Autor do livro.
  - `Genero`: Gênero literário do livro.
  - `AnoPublicacao`: Ano em que o livro foi publicado.
  - `QuantidadeEstoque`: Quantidade de cópias disponíveis do livro no estoque.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.

### 2. Classe `Pessoa`
- **Atributos**:
  - `Nome`: Nome completo da pessoa.
  - `DataNascimento`: Data de nascimento da pessoa.
  - `Endereco`: Endereço residencial da pessoa.
  - `Telefone`: Número de telefone da pessoa.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.

### 3. Classe `Emprestimo`
- **Atributos**:
  - `Livro`: Objeto da classe `Livro` que foi emprestado.
  - `Pessoa`: Objeto da classe `Pessoa` que realizou o empréstimo.
  - `DataEmprestimo`: Data em que o empréstimo foi realizado.
  - `DataDevolucao`: Data prevista para a devolução do livro.
  - `DataLimiteDevolucao`: Data limite para a devolução do livro sem multa.
  - `Multa`: Valor da multa por atraso na devolução.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.

## Utilização
1. Crie instâncias para livros e pessoas.
2. Realize empréstimos associando um livro a uma pessoa e definindo as datas pertinentes.

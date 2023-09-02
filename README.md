# Projeto Biblioteca

## Descrição
O Projeto Biblioteca foi desenvolvido com o objetivo de modelar o sistema básico de uma biblioteca, onde é possível gerenciar empréstimos, livros e usuários (pessoas).

## Estrutura

### 1. Classe `Livro`
- **Atributos**:
  - `titulo`: Título do livro.
  - `autor`: Nome do autor do livro.
  - `anoPublicacao`: Ano em que o livro foi publicado.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.

### 2. Classe `Pessoa`
- **Atributos**:
  - `nome`: Nome completo da pessoa.
  - `dataNascimento`: Data de nascimento da pessoa.
  - `endereco`: Endereço residencial.
  - `email`: E-mail de contato.
  - `telefone`: Número de telefone.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.

### 3. Classe `Emprestimo`
- **Atributos**:
  - `livro`: Objeto da classe `Livro` que foi emprestado.
  - `pessoa`: Objeto da classe `Pessoa` que realizou o empréstimo.
  - `dataEmprestimo`: Data em que o empréstimo foi realizado.
  - `dataDevolucao`: Data prevista para a devolução do livro.

- **Construtor**:
  - Recebe e inicializa os atributos mencionados.
  - 
## Utilização
1. Crie instâncias para livros e pessoas.
2. Realize empréstimos associando um livro a uma pessoa e definindo as datas pertinentes.


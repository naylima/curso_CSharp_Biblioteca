# Projeto Biblioteca

## Descrição
Este projeto modela o sistema de uma biblioteca, abrangendo empréstimos, livros e usuários (pessoas).

## Classes e Estruturas

### 1. `Emprestimo`
 
**Atributos**:
- `DataEmprestimo`: Data em que o empréstimo foi realizado.
- `DataDevolucao`: Data em que o livro foi devolvido.
- `DataLimiteDevolucao`: Data limite para a devolução do livro sem multa.
- `Multa`: Valor da multa por atraso na devolução.
- `Pessoa`: Referência ao usuário que realizou o empréstimo.
- `Livro`: Referência ao livro que foi emprestado.

### 2. `Livro`

**Atributos**:
- `Nome`: Título do livro.
- `Autor`: Autor do livro.
- `Genero`: Gênero literário do livro.
- `AnoPublicacao`: Ano em que o livro foi publicado.
- `QuantidadeEstoque`: Quantidade de cópias disponíveis do livro no estoque.

### 3. `Pessoa`

**Atributos**:
- `Nome`: Nome completo da pessoa.
- `DataNascimento`: Data de nascimento da pessoa.
- `Endereco`: Endereço residencial da pessoa.
- `Telefone`: Número de telefone da pessoa.

## Utilização
1. Crie instâncias para `Livro` e `Pessoa`.
2. Associe um `Livro` a uma `Pessoa` ao criar uma instância de `Emprestimo`, definindo as datas de empréstimo, devolução e limite de devolução.

using System;
using System.Collections.Generic;

namespace Biblioteca
{
    class Program
    {
        static List<Livro> livros = new List<Livro>
        {
            new Livro { Nome = "O Senhor dos Anéis", Autor = "J.R.R. Tolkien", Genero = "Fantasia", AnoPublicacao = 1954, QuantidadeEstoque = 5},
            new Livro { Nome = "1984", Autor = "George Orwell", Genero = "Ficção", AnoPublicacao = 1949, QuantidadeEstoque = 1 },
            new Livro { Nome = "Orgulho e Preconceito", Autor = "Jane Austen", Genero = "Romance", AnoPublicacao = 1813 , QuantidadeEstoque = 0}
        };

        static List<Pessoa> pessoas = new List<Pessoa>
        {
            new Pessoa { Nome = "João", DataNascimento = new DateTime(1990, 5, 12), Endereco = "Rua A", Telefone = "123456789" },
            new Pessoa { Nome = "Maria", DataNascimento = new DateTime(1985, 10, 3), Endereco = "Rua B", Telefone = "987654321" },
            new Pessoa { Nome = "Paula", DataNascimento = new DateTime(1995, 2, 20), Endereco = "Rua C", Telefone = "112233445" }
        };

        static List<Emprestimo> emprestimosAtivos = new List<Emprestimo>();

        static void Main(string[] args)
        {
            RealizarEmprestimo("João", "O Senhor dos Anéis");
            RealizarEmprestimo("Maria", "1984");
            RealizarEmprestimo("Paula", "Orgulho e Preconceito");

            DevolverLivro("João", "O Senhor dos Anéis");
            DevolverLivro("Maria", "1984");
            DevolverLivro("Paula", "Orgulho e Preconceito");

            Console.ReadLine();
        }

        static void RealizarEmprestimo(string nomePessoa, string nomeLivro)
        {
            Livro livroEscolhido = livros.Find(l => l.Nome == nomeLivro);
            Pessoa pessoaEscolhida = pessoas.Find(p => p.Nome == nomePessoa);

            if (livroEscolhido.QuantidadeEstoque <= 0)
            {
                Console.WriteLine($"Desculpe, {nomeLivro} está fora de estoque!");
                return;
            }

            Emprestimo novoEmprestimo = new Emprestimo(pessoaEscolhida, livroEscolhido);
            emprestimosAtivos.Add(novoEmprestimo);
            Console.WriteLine($"{pessoaEscolhida.Nome} pegou o livro '{livroEscolhido.Nome}' em {novoEmprestimo.DataEmprestimo} e deve devolver até {novoEmprestimo.DataLimiteDevolucao}");

            livroEscolhido.QuantidadeEstoque--;
        }

        static void DevolverLivro(string nomePessoa, string nomeLivro)
        {
            Livro livroDevolvido = livros.Find(l => l.Nome == nomeLivro);

            Emprestimo emprestimo = emprestimosAtivos.FirstOrDefault(e => e.Pessoa.Nome == nomePessoa && e.Livro.Nome == nomeLivro);
            if (emprestimo == null)
            {
                Console.WriteLine($"Não encontramos um empréstimo ativo de {nomeLivro} para {nomePessoa}.");
                return;
            }

            emprestimo.DevolverLivro();

            if (emprestimo.Multa > 0)
            {
                Console.WriteLine($"Livro '{nomeLivro}' foi devolvido com atraso. Multa aplicada: {emprestimo.Multa:C}");
            }
            else
            {
                Console.WriteLine($"Livro '{nomeLivro}' foi devolvido no prazo. Sem multa!");
            }

            livroDevolvido.QuantidadeEstoque++;
            emprestimosAtivos.Remove(emprestimo);
        }
    }
}

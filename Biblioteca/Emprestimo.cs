using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        public DateTime DataLimiteDevolucao { get; private set; }
        public decimal Multa { get; private set; }
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }

        private const decimal MULTA_POR_DIA = 1.0m;

        public Emprestimo(Pessoa pessoa, Livro livro)
        {
            Pessoa = pessoa;
            Livro = livro;
            DataEmprestimo = DateTime.Now;
            DataLimiteDevolucao = DataEmprestimo.AddDays(30);
        }

        public void DevolverLivro()
        {
            DataDevolucao = DateTime.Now;
            AplicarMultaSeNecessario();
        }

        private void AplicarMultaSeNecessario()
        {
            if (DataDevolucao > DataLimiteDevolucao)
            {
                int diasDeAtraso = (DataDevolucao - DataLimiteDevolucao).Days;
                Multa = diasDeAtraso * MULTA_POR_DIA;
            }
        }

    }
}

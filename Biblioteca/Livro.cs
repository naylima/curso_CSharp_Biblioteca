using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Livro
    {
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int AnoPublicacao { get; set; }
        public int QuantidadeEstoque { get; set; }
    }
}

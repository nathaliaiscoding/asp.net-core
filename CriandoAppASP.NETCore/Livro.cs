using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_1___Criando_Uma_Aplicação_com_ASP.NET_Core
{
    public class Livro
    {
        public Livro(string codigo, string nome, decimal preco)
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
        }

        public string Codigo { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}

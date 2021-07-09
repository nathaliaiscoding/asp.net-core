using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_1___Criando_Uma_Aplicação_com_ASP.NET_Core
{
    public class Catalogo : ICatalogo
    {
        public List<Livro> GetLivro()
        {
            var livros = new List<Livro>();
            livros.Add(new Livro("001", "Quem mexeu na minha query?", 12.99m));
            livros.Add(new Livro("002", "Fique rico com C#", 30.99m));
            livros.Add(new Livro("003", "Java para baixinhos", 25.99m));

            return livros;
        }
    }
}

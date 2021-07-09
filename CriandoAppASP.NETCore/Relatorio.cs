using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_1___Criando_Uma_Aplicação_com_ASP.NET_Core
{
    public class Relatorio : IRelatorio
    {

        private readonly ICatalogo catalogo;

        public Relatorio(ICatalogo catalogo)
        {
            this.catalogo = catalogo;
        }

        public async Task Imprimir(HttpContext context)
        {
            foreach (var livro in catalogo.GetLivro())
            {
                await context.Response.WriteAsync($"{livro.Codigo,-10}{livro.Nome,-40}{livro.Preco,10}\r\n");
            }
        }
    }
}

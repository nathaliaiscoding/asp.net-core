using System.Collections.Generic;

namespace Aula_1___Criando_Uma_Aplicação_com_ASP.NET_Core
{
    public interface ICatalogo
    {
        List<Livro> GetLivro();
    }
}
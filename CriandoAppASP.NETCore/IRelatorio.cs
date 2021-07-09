using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Aula_1___Criando_Uma_Aplicação_com_ASP.NET_Core
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}
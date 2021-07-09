using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        public IEnumerable<Leilao> BuscarLeiloes();

        public IEnumerable<Categoria> BuscarCategorias();

         Leilao BuscarLeilaoPorId(int id);


         void IncluirLeilao(Leilao obj);

        void EditarLeilao(Leilao obj);


        void RemoverLeilao(Leilao obj);
    }
}
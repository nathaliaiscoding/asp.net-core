using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public class LeilaoDao
    {
        AppDbContext _context;

        public LeilaoDao(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Leilao> BuscarLeiloes() => _context.Leiloes.Include(l => l.Categoria);

        public IEnumerable<Categoria> BuscarCategorias() => _context.Categorias.ToList();

        public Leilao BuscarLeilaoPorId(int id) => _context.Leiloes.Find(id);


        public void IncluirLeilao(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }

        public void EditarLeilao(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public void RemoverLeilao(Leilao obj)
        {
            _context.Leiloes.Remove(obj);
            _context.SaveChanges();
        }
    }
}

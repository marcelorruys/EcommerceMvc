using EcommerceMvc.Context;
using EcommerceMvc.Models;
using EcommerceMvc.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EcommerceMvc.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly AppDbContext _context;

        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.Include(c => c.Categoria);

        public IEnumerable<Produto> ProdutosPreferidos => _context.Produtos.Where(p => p.IsProdutoPreferido).Include(c => c.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
        }
    }
}

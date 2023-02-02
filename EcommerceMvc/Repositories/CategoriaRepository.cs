using EcommerceMvc.Context;
using EcommerceMvc.Models;
using EcommerceMvc.Repositories.Interfaces;

namespace EcommerceMvc.Repositories;

    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }


using EcommerceMvc.Models;

namespace EcommerceMvc.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias {get; }
    }
}

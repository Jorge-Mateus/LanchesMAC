using LanchesMAC.Context;
using LanchesMAC.Models;
using LanchesMAC.Repositories.Interface;

namespace LanchesMAC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}

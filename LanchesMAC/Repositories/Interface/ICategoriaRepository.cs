using LanchesMAC.Models;

namespace LanchesMAC.Repositories.Interface
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}

using LanchesMAC.Repositories.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMAC.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(p => p.CategoriaName);
            return View(categorias);
        }
    }
}

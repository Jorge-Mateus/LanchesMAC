using LanchesMAC.Repositories.Interface;
using LanchesMAC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMAC.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepositRepository;

        public LancheController(ILancheRepository lancheRepositRepository)
        {

            _lancheRepositRepository = lancheRepositRepository;
        }

        public IActionResult List()
        {

            /* var lanche = _lancheRepositRepository.Lanches;
             return View(lanche);*/
            var lancheListViewModel = new LancheListViewModel();
            lancheListViewModel.Lanches = _lancheRepositRepository.Lanches;
            lancheListViewModel.CategoriaAtual = "Categoria Atual";

            return View(lancheListViewModel);
        }
    }
}

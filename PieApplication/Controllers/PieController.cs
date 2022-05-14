using Microsoft.AspNetCore.Mvc;
using PieApplication.Models;
using PieApplication.ViewModels;

namespace PieApplication.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;     
        public PieController(IPieRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }
        public ViewResult List() {
            PieListViewModel pieListViewModel = new PieListViewModel();
            pieListViewModel.Pies=_pieRepository.AllPies;
            pieListViewModel.CurrentCategory = "cheese cakes";
           return View(pieListViewModel);
        }
    }
}

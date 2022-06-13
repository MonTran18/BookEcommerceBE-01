using Microsoft.AspNetCore.Mvc;
using ClassLibrary_RepositoryDLL.Services;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMenuService _repo;
        public MenuController(IMenuService repo) => _repo = repo;

        public IActionResult Index()
        {
            var menu = _repo.getAllCategories();
            return View(menu);
        }
    }
}
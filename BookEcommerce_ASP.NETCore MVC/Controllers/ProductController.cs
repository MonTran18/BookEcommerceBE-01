using Microsoft.AspNetCore.Mvc;
using ClassLibrary_RepositoryDLL.Services;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _repo;
        public ProductController(IProductService repo) => _repo = repo;
        public IActionResult Index(int bookId)
        {
            var book = _repo.getDetailBook(bookId);
            return View(book);
        }
    }
}
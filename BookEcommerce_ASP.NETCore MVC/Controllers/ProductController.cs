using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using ClassLibrary_RepositoryDLL.Models;
using System.Linq;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
   
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IBookRepository _repo;
        private readonly ICheckoutRepository _checkoutRepo;
        private readonly ICartRepository _cart;
        private readonly IAccountRepository _acc;
        private readonly BookEcommerceContext _context;
        public ProductController(ILogger<ProductController> logger, IBookRepository repo, ICheckoutRepository checkoutRepo, BookEcommerceContext context)
        {
            _logger = logger;
            _repo = repo;
            _checkoutRepo = checkoutRepo;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //CART
      //  [Route("addcart/{id}")]
        public IActionResult AddToCart([FromRoute] int id)
        {
            Book book = _repo.getDetailBook(id);
            var books = _context.Books
                .Where(p => p.Id == id)
                .FirstOrDefault();
            if (book == null)
            {
                return NotFound("Không tìm thấy sản phẩm");
            }
            var cart = getCartItems();
            var cartItem = cart.Find(p => p.Book.Id == id);
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                cart.Add(new CartItem()
                {
                    Quantity = 1,
                    Book = book
                });
            }
            SaveCart(cart);
            return RedirectToAction(nameof(Cart));
        }
        [Route("removecart/{id}", Name = "RemoveCartItem")]
        public IActionResult RemoveCartItem([FromRoute] int id)
        {
            var cart = getCartItems();
            var cartItem = cart.Find(p => p.BookId == id);
            if (cartItem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartItem);
            }

            SaveCart(cart);
            return RedirectToAction(nameof(Cart));
        }


       //[Route("/updatecart", Name = "UpdateCart")]
       [HttpPost]
        public IActionResult UpdateCart()
        {

            int id = int.Parse( Request.Form["BookId"].ToString());
            int quantity = int.Parse(Request.Form["Quantity"].ToString());

            // Cập nhật Cart thay đổi số lượng quantity ...
            List<CartItem> cart = getCartItems();
            CartItem cartItem = cart.Find(p => p.Book.Id == id);

            if (cartItem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartItem.Quantity = quantity;
            }
            SaveCart(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return RedirectToAction(nameof(Cart));
        }

        [Route("/cart", Name = "Cart")]
        public IActionResult Cart()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View(getCartItems());
        }
        
       // SESSION
        // JSON key 
        public const string KEY = "cart";

        List<CartItem> getCartItems()
        {
            var session = HttpContext.Session;
            string jsonCart = session.GetString(KEY);
            if (jsonCart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsonCart);
            }
            return new List<CartItem>();
        }

        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(KEY);
        }

    
        void SaveCart(List<CartItem> cartItems)
        {
            var session = HttpContext.Session;
            string jsonCart = JsonConvert.SerializeObject(cartItems);
            session.SetString(KEY, jsonCart);
        }

        [Route("/checkout")]
        //public IActionResult Checkout()
        //{
        //    return View();
        //}
        public IActionResult Checkout(LoginModel model, CheckoutModel ck)
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            // Xử lý khi đặt hàng
            var cart = getCartItems();
            ViewBag.cart = cart;
            ViewBag.size = cart.Count;
            if (HttpContext.Session.GetString("username") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("username");
            }
            else return Redirect(Url.RouteUrl(new { area = "", controller = "User", action = "Login" }));

            if (!string.IsNullOrEmpty(model.Username))
            {
                Checkout checkout = new Checkout();
                checkout.CreateDate = System.DateTime.UtcNow;

                checkout.Username = ck.Username;
                checkout.Depositornumber = ck.Depositornumber;
                checkout.PaymentId = ck.PaymentId;
                _checkoutRepo.addCheckout(checkout);

                ClearCart();
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

    }
}
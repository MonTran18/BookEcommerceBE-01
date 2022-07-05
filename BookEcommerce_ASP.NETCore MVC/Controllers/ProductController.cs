using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
   
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IBookRepository _repo;
        private readonly ICheckoutRepository _checkoutRepo;
        private readonly ICartRepository _cart;
        private readonly IAccountRepository _acc;

        public ProductController(ILogger<ProductController> logger, IBookRepository repo, ICheckoutRepository checkoutRepo)
        {
            _logger = logger;
            _repo = repo;
            _checkoutRepo = checkoutRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        //CART
      //  [Route("addcart/{id}")]
        public IActionResult AddToCart(int id)
        {
            Book book = _repo.getDetailBook(id);
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
            return View(getCartItems());
        }
        
       // SESSION
        // JSON key 
        public const string KEY = "cart";
        public const string key = "checkout";

        public int? Quantity { get; private set; }

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

        List<Checkout> getCheckoutlist()
        {
            var session = HttpContext.Session;
            string jsonCart = session.GetString(key);
            if (jsonCart != null)
            {
                return JsonConvert.DeserializeObject<List<Checkout>>(jsonCart);
            }
            return new List<Checkout>();
        }
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(KEY);
        }

        void ClearCheckout()
        {
            var session = HttpContext.Session;
            session.Remove(key);
        }
        void SaveCart(List<CartItem> cartItems)
        {
            var session = HttpContext.Session;
            string jsonCart = JsonConvert.SerializeObject(cartItems);
            session.SetString(KEY, jsonCart);
        }

        void SaveCheckout(List<Checkout> checkout)
        {
            var session = HttpContext.Session;
            string jsonCart = JsonConvert.SerializeObject(checkout);
            session.SetString(key, jsonCart);
        }

        [Route("/checkout")]
        public IActionResult Checkout([FromForm] string username, [FromForm] string password)
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            // Xử lý khi đặt hàng
            var cart = getCartItems();
            ViewData["username"] = username;
            ViewData["password"] = password;
            ViewBag.cart = cart;
            ViewBag.size = cart.Count;
            if (HttpContext.Session.GetInt32("id") != null)
            {
                ViewBag.id = HttpContext.Session.GetInt32("id");
            }
            else return Redirect(Url.RouteUrl(new { area = "", controller = "User", action = "Login" }));
            if (!string.IsNullOrEmpty(username))
            {
                // hãy tạo cấu trúc db lưu lại đơn hàng và xóa cart khỏi session

                ClearCart();
                RedirectToAction(nameof(Index));
            }

            return View();
        }



        [HttpPost]
        public IActionResult Checkout(FormCollection formCollection)
        {
            Checkout checkout = new Checkout();
            checkout.CreateDate = System.DateTime.UtcNow;
            // checkout.Account.Fullname = formCollection["fullname"];
            checkout.Depositornumber = Convert.ToInt32(formCollection["depositornumber"]);
            checkout.Receivernumber = Convert.ToInt32(formCollection["receivernumber"]);
            //checkout.Phone = formCollection["phonenumber"];
            checkout.Payment.Paymentname = formCollection["paymentmethod"];
            _checkoutRepo.addCheckout(checkout);
            return RedirectToAction("Index", "HomeController");
        }
    }
}
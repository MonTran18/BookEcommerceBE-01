using ClassLibrary_RepositoryDLL.Authentication;
using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using ClassLibrary_RepositoryDLL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Diagnostics;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
    public class UserController : Controller
    {

        private readonly BookEcommerceContext _context;
        public UserController(BookEcommerceContext context)
        {

            _context = context;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterModel model)
        {

            if (ModelState.IsValid)
            {
                Account user = new Account()
                {
                    Fullname = model.Fullname,
                    Username = model.Username,
                    Phone = model.Phone,
                    Password = model.Password,


                };
                _context.Accounts.Add(user);
                await _context.SaveChangesAsync();

            }
            else
            {
                return View("RegisterSuccess");
            }

            return RedirectToAction("RegisterSuccess", "User");
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Accounts
                 .SingleOrDefaultAsync(m => m.Username == model.Username && m.Password == model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt.");
                    return View("Index");
                }
                HttpContext.Session.SetString("Username", user.Username);

            }
            else
            {
                return View("Login");
            }
            return RedirectToAction("LoginSuccess", "User");
        }

        public IActionResult RegisterSuccess()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        //public IActionResult Logout()
        //{
        //    HttpContext.Session.Clear();
        //    return View("Index");
        //}
        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }
        }


    }
}
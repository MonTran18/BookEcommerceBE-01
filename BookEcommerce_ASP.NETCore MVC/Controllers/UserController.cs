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
using Newtonsoft.Json;

namespace BookEcommerce_ASP.NETCore_MVC.Controllers
{
    public class UserController : Controller
    {

        private readonly BookEcommerceContext _context;
        private readonly IAccountRepository _acct;
        public UserController(BookEcommerceContext context, IAccountRepository acct)
        {

            _context = context;
            _acct = acct;
        }

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Account account)
        {

            if (ModelState.IsValid)
            {
                account.Password = HashPassword.CreateMD5Hash(account.Password);
                _context.Accounts.Add(account);
                _context.SaveChanges();
                

            }

            return RedirectToAction("RegisterSuccess", "User");
        }


        public IActionResult Login()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login([Bind("UserName,Password")] Account member)

        {
            var r = _context.Accounts.Where(m => (m.Username == member.Username && m.Password == HashPassword.CreateMD5Hash(member.Password))).ToList();
            var info = _context.Accounts.Where(m => m.Username == member.Username).ToList();
            if (r.Count == 0)
            {

                return View("Login");
            }
            var str = JsonConvert.SerializeObject(member);
            //HttpContext.Session.SetString("username", member.Username);
            HttpContext.Session.SetInt32("id", info[0].Id);
            if (r[0].Carts == null)
            {
                var url = Url.RouteUrl("", new { Controller = "Home", action = "Index", area = "" });
                return Redirect(url);
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult RegisterSuccess()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }

        [HttpPost]
        public JsonResult LogOut()
        {
            HttpContext.Session.Clear();
            return Json(new { success = "True" });
        }
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
using ClassLibrary_RepositoryDLL.Entities;
using ClassLibrary_RepositoryDLL.Models;
using ClassLibrary_RepositoryDLL.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_ASPNETCORE.Controllers
{
    public class LoginController : Controller
    {
        private readonly BookEcommerceContext _context;

        public object StringProcessing { get; private set; }

        public LoginController(BookEcommerceContext context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Login([Bind("UserName,Password")] Account member)

        {
            var r = _context.Accounts.Where(m => (m.Username == member.Username && m.Password == StringProcessing.CreateMD5Hash(member.Password))).ToList();
            var info = _context.Accounts.Where(m => m.Username == member.Fullname).ToList();
            if (r.Count == 0)
            {

                return View("Index");
            }
            //var str = JsonConvert.SerializeObject(member);
            HttpContext.Session.SetString("username", member.Username);
            HttpContext.Session.SetInt32("id", info[0].Id);
            if (r[0].Loai == "0")
            {
                var url = Url.RouteUrl("areas", new { Controller = "Product", action = "Index", area = "Admin" });
                return Redirect(url);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Index()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }
        [HttpPost]
        public JsonResult LoginFB(string name)
        {
            HttpContext.Session.SetString("username", name);
            return Json(new { success = "True" });
        }
        [HttpPost]
        public JsonResult LogOut()
        {
            HttpContext.Session.Clear();
            return Json(new { success = "True" });
        }

    }
}

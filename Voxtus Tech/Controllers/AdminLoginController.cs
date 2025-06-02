using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Voxtus_Tech.Data;
namespace Voxtus_Tech.Controllers
{
    public class AdminLogin : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminLogin(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {

            //if (username == "admin" && password == "password123")
            //{
            //    var claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, username)
            //};
            var user = await _context.LoginModel
            .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

                var claimsIdentity = new ClaimsIdentity(claims, "MyCookieAuth");

                var authProperties = new AuthenticationProperties
                {
                };

                await HttpContext.SignInAsync("MyCookieAuth",
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToAction("ContactDetails", "AdminLogin");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }
        [Authorize]
        public IActionResult ContactDetails()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToAction("Login", "Account");
        }
    }
}
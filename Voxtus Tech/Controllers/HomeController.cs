using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Voxtus_Tech.Models;

namespace Voxtus_Tech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                // Replace this with your own user authentication logic
                if (model.Username == "admin" && model.Password == "password123")
                {
                    // Redirect to a different page upon successful login
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Show an error message
                    ModelState.AddModelError("", "Invalid username or password."); 
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
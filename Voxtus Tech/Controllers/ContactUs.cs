using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class ContactUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

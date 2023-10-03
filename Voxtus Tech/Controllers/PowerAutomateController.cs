using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class PowerAutomateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Unexpected_exception_encountered()
        {
            return View();
        }
    }
}

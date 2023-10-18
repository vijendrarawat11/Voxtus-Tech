using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class PowerAutomateController : Controller
    {
        [Route("blog/power-automate")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("power-apps/power-apps-flow")]
        public ActionResult PowerAppsFlow()
        {
            return View();
        }
        [Route("power-automate/unexpected-exception-encountered")]
        public ActionResult Unexpected_exception_encountered()
        {
            return View();
        }
        [Route("power-apps/mastering-error-handlingin-power-automate-flow")]
        public ActionResult ErrorHandlinginPowerAutomateFlow()
        {
            return View();
        }
    }
}

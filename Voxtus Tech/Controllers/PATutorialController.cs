using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class PATutorialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("learn/power-automate/introduction-to-power-automate")]
        public IActionResult Introduction()
        {
            return View();
        }
        [Route("learn/power-automate/licensing-and-pricing-information")]
        public IActionResult Licensingandpricing()
        {
            return View();
        }
        [Route("learn/power-automate/key-concepts-and-terminology")]
        public IActionResult KeyConceptsandTerminology()
        {
            return View();
        }
        [Route("learn/power-automate/accessing-power-automate")]
        public IActionResult AccessingPowerAutomate()
        {
            return View();
        }
        [Route("learn/power-automate/connectors")]
        public IActionResult Connectors()
        {
            return View();
        }
        [Route("learn/power-automate/triggers")]
        public IActionResult Triggers()
        {
            return View();
        }
        [Route("learn/power-automate/actions")]
        public IActionResult Actions()
        {
            return View();
        }
    }
}

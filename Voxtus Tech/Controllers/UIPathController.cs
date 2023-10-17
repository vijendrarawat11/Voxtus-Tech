using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class UIPathController : Controller
    {
        [Route("ui-path")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("ui-path/ui-path-vs-power-automate")]
        public IActionResult UiPathVsPowerAutomate()
        {
            return View();
        }
        [Route("ui-path/ui-path-orchestrator")]
        public IActionResult UiPathOrchestrator()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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
        [Route("learn/power-automate/basic-flow-using-template")]
        public IActionResult BasicFlowusingTemplate()
        {
            return View();
        }
        [Route("learn/power-automate/automated-trigger-flows")]
        public IActionResult AutomatedTriggerFlows()
        {
            return View();
        }
        [Route("learn/power-automate/instant-trigger-flows")]
        public IActionResult InstantTriggerFlows()
        {
            return View();
        }
        [Route("learn/power-automate/scheduled-trigger-flows")]
        public IActionResult ScheduledTriggerFlows()
        {
            return View();
        }
        [Route("learn/power-automate/expressions-and-variables")]
        public IActionResult ExpressionsandVariables()
        {
            return View();
        }
        [Route("learn/power-automate/expressions-&-variables-example")]
        public IActionResult ExpressionsandVariablesExample()
        {
            return View();
        }
        [Route("learn/power-automate/using-conditions-and-switches")]
        public IActionResult ConditionsandSwitches()
        {
            return View();
        }
        [Route("learn/power-automate/creating-loops-and-iterations")]
        public IActionResult LoopsandIterations()
        {
            return View();
        }
    }
}

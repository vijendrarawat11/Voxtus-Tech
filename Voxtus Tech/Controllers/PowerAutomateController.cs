using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.Intrinsics.X86;

namespace Voxtus_Tech.Controllers
{
    public class PowerAutomateController : Controller
    {
        [Route("blogs/power-automate")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("blogs/power-automate/power-apps-flow")]
        public ActionResult PowerAppsFlow()
        {
            return View();
        }
        [Route("blogs/power-automate/unexpected-exception-encountered")]
        public ActionResult Unexpected_exception_encountered()
        {
            return View();
        }
        [Route("blogs/power-automate/mastering-error-handlingin-power-automate-flow")]
        public ActionResult ErrorHandlinginPowerAutomateFlow()
        {
            return View();
        }
        [Route("blogs/power-automate/create-table-in-excel-through-microsoft-power-automate")]
        public ActionResult CreateExcelthroughPowerAutomate()
        {
            return View();
        }
        [Route("blogs/power-automate/import-excel-data-in-sharepoint-list-through-power-automate-flow")]
        public ActionResult ImportExcelDatainSharePoint()
        {
            return View();
        }
        [Route("blogs/power-automate/exploring-virtual-tables-in-dataverse-with-sharepoint-connector")]
        public ActionResult ExploringVirtualTablesinDataverse()
        {
            return View();
        }
        [Route("blogs/power-automate/effectively-use-power-automate-filter-query")]
        public ActionResult PowerAutomateFilterQuery()
        {
            return View();
        }
    }
}

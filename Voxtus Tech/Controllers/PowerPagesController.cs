using Microsoft.AspNetCore.Mvc;

namespace Voxtus_Tech.Controllers
{
    public class PowerPagesController : Controller
    {
        [Route("blogs/power-pages")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("blogs/power-pages/how-to-add-a-document-location-subgrid-in-a-form-with-sharepoint-integration")]
        public IActionResult EnableSharePointIntegration()
        {
            return View();
        }
    }
}

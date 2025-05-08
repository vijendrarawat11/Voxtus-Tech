using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;

namespace Voxtus_Tech.Controllers
{
    public class PowerAppsController : Controller
    {
        // GET: PowerAppsController
        [Route("blogs/power-apps")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: PowerAppsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PowerAppsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PowerAppsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PowerAppsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PowerAppsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PowerAppsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PowerAppsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [Route("blogs/power-apps/bar-code-reader")]
        public ActionResult BarCodeReader()
        {
            return View();
        }
        [Route("blogs/power-apps/multiple-maker-feature")]
        public ActionResult MultipleMakerFeature()
		{
			return View();
		}
        [Route("blogs/power-apps/canvas-app-vs-model-driven-app")]
        public ActionResult CanvasOrModelDrivenApp()
        {
            return View();
        }
        [Route("blogs/power-apps/customizing-controls")]
        public ActionResult CustomizingControls()
        {
            return View();
        }
        
        [Route("blogs/power-apps/building-custom-forms")]
        public ActionResult BuildingCustomForms()
        {
            return View();
        }

        [Route("blogs/power-apps/environment-variables")]
        public ActionResult Environment_variables()
        {
            return View();
        }
        [Route("blogs/power-apps/using-git-for-version-control")]
        public ActionResult Using_Git_for_Version_Control()
        {
            return View();
        }
        [Route("blogs/power-apps/using-with-function")]
        public ActionResult Using_with_function()
        {
            return View();
        }
        [Route("blogs/power-apps/auto-scrollable-gallery-control-in-power-apps")]
        public ActionResult AutoScrollableGalleryControl()
        {
            return View();
        }
        [Route("blogs/power-apps/mastering-multi-value-dropdown-in-power-apps")]
        public ActionResult MasteringMultiValueDropdown()
        {
            return View();
        }
        [Route("blogs/power-apps/understanding-variables-in-power-apps-a-comprehensive-guide")]
        public ActionResult UnderstandingVariablesinPowerApps()
        {
            return View();
        }

    }
}

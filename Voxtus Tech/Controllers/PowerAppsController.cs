using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Voxtus_Tech.Controllers
{
    public class PowerAppsController : Controller
    {
        // GET: PowerAppsController
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


        public ActionResult BarCodeReader()
        {
            return View();
        }

		public ActionResult MultipleMakerFeature()
		{
			return View();
		}
        public ActionResult CanvasOrModelDrivenApp()
        {
            return View();
        }
        public ActionResult CustomizingControls()
        {
            return View();
        }
        public ActionResult PowerAppsFlow()
        {
            return View();
        }
        public ActionResult BuildingCustomForms()
        {
            return View();
        }
        public ActionResult ErrorHandlinginPowerAutomateFlow()
        {
            return View();
        }
        public ActionResult Environment_variables()
        {
            return View();
        }

    }
}

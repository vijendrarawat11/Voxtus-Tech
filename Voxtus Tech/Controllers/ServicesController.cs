﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace Voxtus_Tech.Controllers
{
    public class ServicesController : Controller
    {
        // GET: ServicesController
        [Route("our-services")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServicesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ServicesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicesController/Create
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

        // GET: ServicesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServicesController/Edit/5
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

        // GET: ServicesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServicesController/Delete/5
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
        [Route("our-services/power-platform-development")]
        public ActionResult PowerPlatformDevelopment()
        {
            return View();
        }
        [Route("our-services/dynamics365-development")]
        public ActionResult Dynamics365Development()
        {
            return View();
        }
        [Route("our-services/dot-net-development")]
        public ActionResult DOTNETDevelopment()
        {
            return View();
        }
        [Route("our-services/rpa-development")]
        public ActionResult RPADevelopment()
        {
            return View();
        }
        [Route("our-services/terms-of-services")]
        public ActionResult TermsofServices()
        {
            return View();
        }
        [Route("our-services/search-engine-optimization")]
        public ActionResult SearchEngineOptimization()
        {
            return View();
        }

    }
}

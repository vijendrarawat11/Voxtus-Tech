﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Voxtus_Tech.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: PortfolioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PortfolioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PortfolioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PortfolioController/Create
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

        // GET: PortfolioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PortfolioController/Edit/5
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

        // GET: PortfolioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PortfolioController/Delete/5
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
        public ActionResult HealthManagementSystemApp()
        {
            return View();
        }
        public ActionResult EmployeeOnboardingApp()
        {
            return View();
        }
        public ActionResult StudentManagementApplicationApp()
        {
            return View();
        }
        public ActionResult InspectionApp()
        {
            return View();
        }
        public ActionResult LeaveManagementApplicationApp()
        {
            return View();
        }
        public ActionResult OrderTrackingApplication()
        {
            return View();
        }
        public ActionResult EmployeePerformanceReviewingSystemApp()
        {
            return View();
        }
        public ActionResult BillingProcessAutomation()
        {
            return View();
        }
    }
}

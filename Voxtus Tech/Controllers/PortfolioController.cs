using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Voxtus_Tech.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: PortfolioController
        [Route("potfolio")]
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
        [Route("potfolio/canvas-app/health-management-system-app")]
        public ActionResult HealthManagementSystemApp()
        {
            return View();
        }
        [Route("potfolio/model-driven-app/employee-onboarding-app")]
        public ActionResult EmployeeOnboardingApp()
        {
            return View();
        }
        [Route("potfolio/model-driven-app/student-management-application")]
        public ActionResult StudentManagementApplicationApp()
        {
            return View();
        }
        [Route("potfolio/canvas-app/inspection-app")]
        public ActionResult InspectionApp()
        {
            return View();
        }
        [Route("potfolio/canvas-app/leave-management-application")]
        public ActionResult LeaveManagementApplicationApp()
        {
            return View();
        }
        [Route("potfolio/canvas-app/order-tracking-application")]
        public ActionResult OrderTrackingApplication()
        {
            return View();
        }
        [Route("potfolio/canvas-app/employee-performance-reviewing-system-app")]
        public ActionResult EmployeePerformanceReviewingSystemApp()
        {
            return View();
        }
        [Route("potfolio/ui-path/billing-process-automation")]
        public ActionResult BillingProcessAutomation()
        {
            return View();
        }
        [Route("potfolio/power-automate/web_scraping_for_data_retrieval")]
        public ActionResult Web_Scraping_for_Data_Retrieval()
        {
            return View();
        }
    }
}

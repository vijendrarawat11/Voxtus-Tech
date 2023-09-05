using Microsoft.AspNetCore.Mvc;
using Voxtus_Tech.Data;
using Voxtus_Tech.Models;

namespace Voxtus_Tech.Controllers
{
    public class NewsletterController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NewsletterController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Newsletter> objectlist = (IEnumerable<Newsletter>)_context.Newsletters;
            return View(objectlist);
        }
        public IActionResult _Layout()
        { 
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult _Layout(Newsletter obj)
        {
            if (ModelState.IsValid)
            {
                _context.Newsletters.Add(obj);
                _context.SaveChanges();
            }
            return View();
        }

    }
}

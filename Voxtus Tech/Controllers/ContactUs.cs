using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Voxtus_Tech.Data;
using Voxtus_Tech.Models;

namespace Voxtus_Tech.Controllers
{
    public class ContactUs : Controller
    {
        private readonly ApplicationDbContext _db;

        public ContactUs(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(Models.ContactUs obj)
        //{
        //    if (obj == null)
        //    {
        //        _db.ContactUs.Add(obj);
        //        _db.SaveChanges();
        //        return View();
        //    }
           
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Models.ContactUs obj)
        {
            //ModelState["PhoneNo"].ValidationState = ModelValidationState.Valid;
            if (ModelState.IsValid)
                {

                //_db.Entry(obj).Property(u => u.PhoneNo).IsModified = false;
                _db.ContactUs.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Your message has been sent. Thank you!";
                return RedirectToAction("Index","ContactUs");
            }
          
            return View();
        }
        public IActionResult Create()
        {
            IEnumerable<ContactUs> objectlist = (IEnumerable<ContactUs>)_db.ContactUs;
            return View(objectlist);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Models.ContactUs obj)
        {
            if (obj != null)
            {
                _db.ContactUs.Add(obj);
                _db.SaveChanges();

            }
            return View();
        }
    }
}

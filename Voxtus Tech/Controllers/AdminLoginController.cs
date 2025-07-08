using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Voxtus_Tech.Data;
namespace Voxtus_Tech.Controllers
{
    public class AdminLogin : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminLogin(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {

            //if (username == "admin" && password == "password123")
            //{
            //    var claims = new List<Claim>
            //{
            //    new Claim(ClaimTypes.Name, username)
            //};
            var user = await _context.LoginModel
            .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.Username)
            };

                var claimsIdentity = new ClaimsIdentity(claims, "MyCookieAuth");

                var authProperties = new AuthenticationProperties
                {
                };

                await HttpContext.SignInAsync("MyCookieAuth",
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToAction("ContactDetails", "AdminLogin");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }
        [Authorize]
        //public IActionResult ContactDetails()
        //{
        //    return View();
        //}

        // List all ContactUs entries
        public async Task<IActionResult> ContactDetails()
        {
            var contacts = await _context.ContactUs
        .OrderByDescending(c => c.CreatedDateTime) // ✅ This line sorts the records
        .ToListAsync();

            return View("ContactDetails", contacts);
        }

        // View a single ContactUs record
        public async Task<IActionResult> Details(int id)
        {
            var contact = await _context.ContactUs.FirstOrDefaultAsync(c => c.Id == id);
            if (contact == null) return NotFound();
            return View(contact);
        }

        // Confirm delete view (optional)
        public async Task<IActionResult> Delete(int id)
        {
            var contact = await _context.ContactUs.FindAsync(id);
            if (contact == null)
            {
                return NotFound();
            }

            _context.ContactUs.Remove(contact);
            await _context.SaveChangesAsync();

            TempData["Message"] = "Record deleted successfully!";
            return RedirectToAction("ContactDetails");
        }

        // Delete confirmed
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contact = await _context.ContactUs.FindAsync(id);
            if (contact != null)
            {
                _context.ContactUs.Remove(contact);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(ContactDetails));
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("MyCookieAuth");
            return RedirectToAction("Login", "Account");
        }
    }
}
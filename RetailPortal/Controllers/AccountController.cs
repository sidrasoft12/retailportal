using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace RetailPortal.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string phone)
        {
            // Simulate login logic
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(phone))
            {
                // Extract the first part of the email
                var userName = email.Split('@')[0];
                // Set the user's first name in the session
                HttpContext.Session.SetString("UserName", userName);
                TempData["SponsorEmail"] = email;
                TempData["SponsorPhone"] = phone;
                return RedirectToAction("Index", "GMQuotation");
            }

            // If login fails, reload the login page
            return View();
        }
    }
}

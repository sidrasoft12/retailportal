using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class SponsorController : Controller
    {
        public IActionResult Login()
        {
            ViewBag.ActiveTab = "Sponsor";
            ViewBag.SponsorName = HttpContext.Session.GetString("UserEmail") ?? "Email";
            return View();
        }
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Sponsor";
            ViewBag.SponsorName = "Email";
            return View();
        }
        [HttpPost]
        public IActionResult SubmitSponsor()
        {
            
            return RedirectToAction("Index", "Policy");
        }
    }
}

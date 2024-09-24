using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Member";
            ViewBag.SponsorName = "User";
            return View();
        }
        public IActionResult SubmitMember()
        {
            
            return RedirectToAction("Index", "Product");
        }
    }
}
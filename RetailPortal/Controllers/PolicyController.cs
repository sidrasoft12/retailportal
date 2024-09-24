using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class PolicyController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Policy";
            ViewBag.SponsorName = "User";
            return View();
        }
    }
}

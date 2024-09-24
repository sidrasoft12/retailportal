using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Product";
            ViewBag.SponsorName = "User";
            return View();
        }
        public IActionResult NextProduct()
        {
            
            return RedirectToAction("Index", "Payment");
        }
        //public IActionResult BackProduct()
        //{
        //    return RedirectToAction("Index", "Member");
        //}
    }
}
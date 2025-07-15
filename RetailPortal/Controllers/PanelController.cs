using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class PanelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


       //HttpPost]
        //public IActionResult RedirectLogin()
        //{
        //    return RedirectToAction("Login", "Account");
        //}
    }
}

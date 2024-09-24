using Microsoft.AspNetCore.Mvc;

namespace RetailPortal.Controllers
{
    public class PaymentController : Controller
    {
        // Load the payment form
        public IActionResult Index()
        {
            ViewBag.ActiveTab = "Payment";
            ViewBag.SponsorName = "User";
            return View();
        }

        // Placeholder for future server-side handling
        [HttpPost]
        public IActionResult Submit()
        {
            // Handle form submission logic here (e.g., save data to the database)
            // For now, we are not doing anything as we are handling everything client-side

            return RedirectToAction("Index");
        }
    }
}

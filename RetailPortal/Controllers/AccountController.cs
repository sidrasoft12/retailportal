using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace RetailPortal.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet("Login/{agent_id}")]
        public IActionResult Login(int agent_id)
        {

            ViewBag.AgentId = agent_id;
            HttpContext.Session.SetInt32("AgentId", agent_id);

            ViewBag.DefDate = DateTime.Now.ToString("MM/dd/yyyy");

            return View();
        }

        [HttpPost("Login/{agent_id}")]
        public IActionResult Login(string email, string phone, DateTime policyStartDate)
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
                TempData["PlanStartDate"] = policyStartDate;
                int? agentId = HttpContext.Session.GetInt32("AgentId");
                ViewBag.AgentId = agentId.Value;
                if (agentId.HasValue)
                {
                    return RedirectToAction("Index", "GMQuotation");
                }
                
            }

            // If login fails, reload the login page
            return View();
        }
    }
}

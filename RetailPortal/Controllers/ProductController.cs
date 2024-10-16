using Microsoft.AspNetCore.Mvc;
using RetailPortal.Models;

namespace RetailPortal.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly PlanCategoryBenefits _service;


        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
            _service = new PlanCategoryBenefits(configuration);
        }
        public IActionResult Index()
        {
            int agentId = 76;
            var agentDetails = GetAgentDetails(agentId);

            ViewBag.AgentName = agentDetails.Name;
            ViewBag.AgentTelephone = agentDetails.Telephone;
            ViewBag.AgentEmail = agentDetails.Email;
            ViewBag.AgentAddress = agentDetails.Address;
            ViewBag.AgentCity = agentDetails.City;
            ViewBag.AgentWebsite = agentDetails.Website;
            ViewBag.AgentFax = agentDetails.Fax;

            ViewBag.AgentDetails = $"<strong>Name</strong> - {ViewBag.AgentName}<br>" +
         $"<strong>Telephone</strong> - {ViewBag.AgentTelephone}<br>" +
         $"<strong>Address</strong> - {ViewBag.AgentAddress}<br>" +
         $"<strong>Email</strong> - {ViewBag.AgentEmail}<br>" +
         $"<strong>City</strong> - {ViewBag.AgentCity}<br>" +
         $"<strong>Website</strong> - {ViewBag.AgentWebsite}<br>" +
         $"<strong>Fax</strong> - {ViewBag.AgentFax}";

            // Set sponsor details from TempData or initialize as needed
            ViewBag.SponsorEmail = TempData["SponsorEmail"] ?? string.Empty;
            ViewBag.SponsorPhone = TempData["SponsorPhone"] ?? string.Empty;

            var membersModel = new Members
            {
                BrokerId = agentId
            };

            return View(membersModel);
        }
        private Agent GetAgentDetails(int agentId)
        {
            var agents = new List<Agent>
            {
                new Agent { Id = 76, Name = "AIC FAV DISTRIBUTOR",
                    Telephone = "+971502444355",
                    Email = "amoheeput@rgare.com",
                    Address = "Dubai",
                    City = "Dubai",
                    Website = "test.com",
                    Fax = "test123" }
            };
            return agents.FirstOrDefault(a => a.Id == agentId);
        }
        public class Agent
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Telephone { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string Website { get; set; }
            public string Fax { get; set; }

        }
        [HttpGet]

        public IActionResult _ProductDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {
            try
            {
                List<PlanCategoryBenefits> productList = _service.GetPlanCategoryBenefitsList(whereCondition, pagingCondition, orderByExpression).Take(5).ToList(); 
                return View(productList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Index", "Product");
            }
        }

    }
}
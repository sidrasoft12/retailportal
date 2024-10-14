using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RetailPortal.Models;
using System.Reflection;

namespace RetailPortal.Controllers
{
    public class GMQuotationController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly GMQuotations _service;


        public GMQuotationController(IConfiguration configuration)
        {
            _configuration = configuration;
            _service = new GMQuotations(configuration); // Pass configuration to GMQuotations
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

            var quotationModel = new GMQuotations
            {
                BrokerId = agentId
            };

            return View(quotationModel);
        }
        [HttpPost]

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


        [HttpGet]

        public IActionResult _SponsorAandPolicyDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {

            List<GMQuotations> quotationsList = _service.GetGMQuotationsList(whereCondition, pagingCondition, orderByExpression);
            return View(quotationsList);
        }



        [HttpPost]
        public IActionResult InsertQuotations(GMQuotations model)
        {

            model.SetConfiguration(_configuration);
            long result = model.SaveEntity("new");

            // Redirect to the QuotationsList after successful save
            return RedirectToAction("_SponsorAandPolicyDetails");
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
    }
}







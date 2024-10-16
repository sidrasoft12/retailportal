using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RetailPortal.Models;
using System.Reflection;

namespace RetailPortal.Controllers
{
    public class MemberController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly Members _service;


        public MemberController(IConfiguration configuration)
        {
            _configuration = configuration;
            _service = new Members(configuration); // Pass configuration to GMQuotations
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

        [HttpGet]
        
        public IActionResult _MemberAdd()
        {
            
            return View(new Members());
        }

        public IActionResult _MemberEdit(int id)
        {
           
            string whereCondition = $"GMQuotationMemberId = {id}"; // Adjust this condition based on your database field
            List<Members> membersList = _service.GetMembersList(whereCondition, string.Empty, string.Empty);

            Members member = membersList.FirstOrDefault();
            if (member == null)
            {
                return NotFound();
            }
            return View("_MemberEdit", member);
        }


        [HttpGet]

        public IActionResult _MemberDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<Members> membersList = _service.GetMembersList(whereCondition, pagingCondition, orderByExpression);
            return View(membersList);
        }

        public IActionResult InsertMembers(Members model)
        {



            model.SetConfiguration(_configuration);
            long result = model.SaveEntity("new");
            return RedirectToAction("_MemberDetails");
        }

        public IActionResult RemoveMember(int id)
        {
            try
            {
                
                bool isDeleted = _service.DeleteMember(id); // Make sure this method returns true if successful

                // Return JSON response indicating success
                if (isDeleted)
                {
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, message = "Member not found or could not be deleted." });
                }
            }
            catch (Exception ex)
            {
                // Handle exception and return error response
                return Json(new { success = false, message = ex.Message });
            }
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
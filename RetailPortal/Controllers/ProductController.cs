using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using RetailPortal.Models;

namespace RetailPortal.Controllers
{
    public class ProductController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly Mstr_PlanCategoryBenefits _service;
        private long _GMQuotationId;


        public ProductController(IConfiguration configuration)
        {
            _configuration = configuration;
            _service = new Mstr_PlanCategoryBenefits(configuration);
        }
        [HttpGet("{agent_id}/Product/Index")]
        public IActionResult Index()
        {
            int? agentId = HttpContext.Session.GetInt32("AgentId");
            // Fetch agent details from the database based on agentId
            var agentDetails = GetAgentDetailsFromDatabase(agentId.Value);

            if (agentDetails == null)
            {
                return NotFound("Agent not found.");
            }

            // Populate ViewBag with agent details
            ViewBag.AgentName = agentDetails.Name;
            ViewBag.AgentTelephone = agentDetails.Telephone;
            ViewBag.AgentEmail = agentDetails.Email;
            ViewBag.AgentAddress = agentDetails.Address;
            ViewBag.BranchName = agentDetails.BranchName;
            //ViewBag.AgentWebsite = agentDetails.Website;
            //ViewBag.AgentFax = agentDetails.Fax;

            ViewBag.AgentDetails = $"<strong>Name</strong> - {ViewBag.AgentName}<br>" +
                $"<strong>Telephone</strong> - {ViewBag.AgentTelephone}<br>" +
                $"<strong>Address</strong> - {ViewBag.AgentAddress}<br>" +
                $"<strong>Email</strong> - {ViewBag.AgentEmail}<br>" +
                $"<strong>BranchName</strong> - {ViewBag.BranchName}<br>"
            ;

            // Set sponsor details from TempData or initialize as needed
            ViewBag.SponsorEmail = TempData["SponsorEmail"] ?? string.Empty;
            ViewBag.SponsorPhone = TempData["SponsorPhone"] ?? string.Empty;

            // Initialize the quotation model
            var productModel = new Mstr_PlanCategoryBenefits
            {
                BrokerId = agentId.Value,
                BrokerName = agentDetails.Name,
                BrokerTelephone = agentDetails.Telephone,
                BrokerAddress = agentDetails.Address,
                BrokerEmail = agentDetails.Email,
                BranchName = agentDetails.BranchName
            };


            return View(productModel);

            //var prodModel = new Mstr_PlanCategoryBenefits { AdditionalPremiumAmt = 0 };
            List<Mstr_PlanCategoryBenefits> productList = _service.GetMstr_PlanCategoryBenefitsList("","","").Take(5).ToList();
            return View(productList);
            //return View();

        }

        // Fetch agent details from the database
        private Agent GetAgentDetailsFromDatabase(int agentId)
        {
            if (_configuration == null)
            {
                throw new InvalidOperationException("Configuration is not set. Ensure _Config is initialized.");
            }

            var connectionString = _configuration.GetConnectionString("ConnString");

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var query = "SELECT * FROM mstr_agents WHERE Id = @AgentId";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AgentId", agentId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Agent
                            {
                                Id = reader.GetInt64(reader.GetOrdinal("Agent_Id")),
                                Name = reader.GetString(reader.GetOrdinal("Agent_Name")),
                                Telephone = reader.GetString(reader.GetOrdinal("Phone")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                BranchName = reader.GetString(reader.GetOrdinal("Branch_Name")),
                                //Website = reader.GetString(reader.GetOrdinal("Website")),
                                //Fax = reader.GetString(reader.GetOrdinal("Fax"))
                            };
                        }
                    }
                }
            }

            return null; // Agent not found
        }
        public class Agent
        {
            public long Id { get; set; }
            public string? Name { get; set; }
            public string? Telephone { get; set; }
            public string? Email { get; set; }
            public string? Address { get; set; }
            public string? BranchName { get; set; }
            public string? Website { get; set; }
            public string? Fax { get; set; }

        }
        [HttpGet("{agent_id}/Product/_ProductDetails")]

        public IActionResult _ProductDetails(string whereCondition, string pagingCondition, string orderByExpression)


        {
            try
            {
                List<Mstr_PlanCategoryBenefits> productList = _service.GetMstr_PlanCategoryBenefitsList(whereCondition, pagingCondition, orderByExpression).Take(5).ToList();
                return View(productList);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return RedirectToAction("Index", "Product");
            }
        }
        public IActionResult InsertProducts(Mstr_PlanCategoryBenefits model)
        {

            model.SetConfiguration(_configuration);
            if (TempData["GMQuotationID"] != null)
            {
                _GMQuotationId = long.Parse(TempData["GMQuotationID"].ToString());
            }
            model.GMQuotationId = _GMQuotationId;
            long result = model.SaveEntity("new");
            return RedirectToAction("_ProductDetails");
        }

    }
}
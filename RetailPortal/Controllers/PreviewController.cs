using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RetailPortal.Models;
using System;
using System.Collections.Generic;

namespace RetailPortal.Controllers
{
    public class PreviewController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly GMQuotations _serviceQ;
        private readonly Members _serviceM;
        private readonly Mstr_PlanCategoryBenefits _serviceP;

        public PreviewController(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration), "Configuration cannot be null.");
            _serviceQ = new GMQuotations(configuration); // Pass configuration to GMQuotations service
            _serviceM = new Members(configuration); // Pass configuration to Members service
            _serviceP = new Mstr_PlanCategoryBenefits(configuration);
        }

        // Index action to render the preview
        [HttpGet("/Preview/Index")]
        public IActionResult Index()
        {
            ViewBag.HideHeader = true;
            ViewBag.QuotationId = TempData["GMQuotationID"];
            int? quotationId = ViewBag.QuotationId != null ? Convert.ToInt32(ViewBag.QuotationId) : (int?)null;
            string whereCondition = $"GMQuotationId = {quotationId}";
            string pagingCondition = "";
            string orderByExpression = "";

            var quotationsList = QuotationDetails(whereCondition, pagingCondition, orderByExpression);
            var membersList = MemberDetails(whereCondition, pagingCondition, orderByExpression);
            var productsList = ProductDetails(whereCondition, pagingCondition, orderByExpression);

            var model = new Preview
            {
                QuotationDetails = quotationsList,
                MemberDetails = membersList,
                ProductDetails = productsList
            };

            return View(model);
        }

        // Method to fetch the quotation details based on conditions
        [HttpGet]
        private List<GMQuotations> QuotationDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<GMQuotations> quotationsList = _serviceQ.GetGMQuotationsList(whereCondition, pagingCondition, orderByExpression);
            return quotationsList;
        }

        // Method to fetch the member details based on conditions
        [HttpGet]
        private List<Members> MemberDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<Members> membersList = _serviceM.GetMembersList(whereCondition, pagingCondition, orderByExpression);
            return membersList;
        }
        [HttpGet]
        private List<Mstr_PlanCategoryBenefits> ProductDetails(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<Mstr_PlanCategoryBenefits> productsList = _serviceP.GetMstr_PlanCategoryBenefitsList(whereCondition, pagingCondition, orderByExpression);
            return productsList;
        }
    }
}

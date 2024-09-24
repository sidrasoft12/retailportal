using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RetailPortal.Models;

namespace RetailPortal.Controllers
{
    public class GMQuotationController : Controller
    {
        private readonly GMQuotations _service;

        public GMQuotationController(GMQuotations service)
        {
            _service = service;
        }
        [HttpGet]
        //public IActionResult Quotations(string result)
        //{
        //    result = _service.Get(result);
        //    return RedirectToAction("Index", "GMQuotation", new { quotationNumber = result });
        //}
        //public IActionResult Index(string quotationNumber)
        //{
        //    //Example: pass quotation number to a view
        //    ViewBag.QuotationNumber = quotationNumber;
        //    return View();
        //}
        public IActionResult QuotationsList(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<GMQuotations> quotationsList = _service.GetGMQuotationsList(whereCondition, pagingCondition, orderByExpression);
            return View(quotationsList);
        }

        public IActionResult InsertQuotations()
        {
            var Insert = _service.Insert();
            return View(Insert);
        }
    }
}

using RetailPortal.Models;
using Microsoft.AspNetCore.Mvc;


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

    [HttpGet("/Product/Index")]
    public IActionResult Index(string whereCondition, string pagingCondition, string orderByExpression)
    {
        try
        {
            List<Mstr_PlanCategoryBenefits> productList = _service.GetMstr_PlanCategoryBenefitsList(whereCondition, pagingCondition, orderByExpression).Take(5).ToList();
            return View("Index", productList);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return RedirectToAction("Index", "Product");
        }
    }

    [HttpGet("/Product/_ProductDetails")]
    public IActionResult _ProductDetails(string whereCondition, string pagingCondition, string orderByExpression)
    {
        try
        {
            List<Mstr_PlanCategoryBenefits> productList = _service.GetMstr_PlanCategoryBenefitsList(whereCondition, pagingCondition, orderByExpression).Take(5).ToList();
            return PartialView("_ProductDetails", productList); 
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return RedirectToAction("Index", "Product");
        }
    }
    [HttpPost("InsertProducts")]
    public IActionResult InsertProducts(Mstr_PlanCategoryBenefits model)
    {
        model.SetConfiguration(_configuration);
        if (TempData["GMQuotationID"] != null)
        {
            _GMQuotationId = long.Parse(TempData["GMQuotationID"].ToString());
        }
        model.GMQuotationId = _GMQuotationId;
        long result = model.SaveEntity("new");
        int? agentId = HttpContext.Session.GetInt32("AgentId");
        return RedirectToAction("Index", "Payment");
    }
}

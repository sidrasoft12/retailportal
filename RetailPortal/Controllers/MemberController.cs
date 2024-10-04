using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using RetailPortal.Models;

namespace RetailPortal.Controllers
{
    public class MemberController : Controller
    {
        private readonly Members _service;

        public MemberController(Members service)
        {
            _service = service;
        }
        [HttpGet]
   
        public IActionResult MembersList(string whereCondition, string pagingCondition, string orderByExpression)
        {
            List<Members> membersList = _service.GetMembersList(whereCondition, pagingCondition, orderByExpression);
            return View(membersList);
        }

        public IActionResult InsertMembers()
        {
            _service.SaveEntity("new");
            return RedirectToAction("MembersList");
        }
    }
}

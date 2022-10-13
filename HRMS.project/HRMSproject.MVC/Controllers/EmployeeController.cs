using HRMSproject.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HRMSproject.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBusiness _empBusiness;
        public EmployeeController(IEmployeeBusiness empBusiness)
        {
            _empBusiness = empBusiness;
        }
        public IActionResult Index()
        {
            var list = _empBusiness.GetAllEmployees();
            return View();
        }
    }
}

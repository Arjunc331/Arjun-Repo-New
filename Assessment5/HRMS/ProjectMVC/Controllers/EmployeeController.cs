using HRMSProject.Bussiness.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ProjectMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBussiness _employeeBussiness;
        public EmployeeController(IEmployeeBussiness empBussiness )
        {
            _employeeBussiness = empBussiness;
        }
        public async Task<IActionResult> Index()
        {
            var list = await _employeeBussiness.GetAllEmployees();
            return View(list);
        }
    }
}
